define(['httpRequest', "ui", "underscore", "cryptojs", "sha1"], function (httpRequest, ui) {
	var url = 'http://jsapps.bgcoder.com/', /*'http://localhost:3000/',*/
		contentType = 'application/json',
		acceptType = 'application/json';

	var navigateTo = function (location) {
		window.location.hash = location;
	}

	var login = function (username, password) {
		var message,
			authCode;

		authCode = CryptoJS.SHA1(username + password).toString();

		message = {
			"username": username,
			"authCode": authCode
		};

		// move all strings to consts
		httpRequest.postJSON(url + 'auth', contentType, acceptType, message)
			.then(function (success) {
				localStorage.setItem("crowdShareUserName", username);
				localStorage.setItem("crowdShareSessionKey", success.sessionKey);

				navigateTo('#/');
			})
			.then(null, function (err) {
				alert(JSON.parse(err.responseText).message);
			});
	};

	var logout = function () {
		var sessionKey = localStorage.getItem('crowdShareSessionKey');

		httpRequest.postJSON(url + 'user', contentType, acceptType, null, sessionKey)
			.then(function (success) {
				localStorage.setItem("crowdShareUserName", '');
				localStorage.setItem("crowdShareSessionKey", '');

				navigateTo('#/');
			})
			.then(null, function (err) {
				alert(JSON.parse(err.responseText).message);
			});
	};

	var registerAccount = function (username, password) {
		var message,
			authCode = username + password;

		authCode = CryptoJS.SHA1(authCode).toString();

		// move message to consts
		message = {
			"username": username,
			"authCode": authCode
		};

		httpRequest.postJSON(url + 'user', contentType, acceptType, message)
			.then(function (success) {
				$('#register-nickname').val(' ');
				$('#register-password').val(' ');
				$('#repeat-register-password').val(' ');

				alert('You have been registered. Now you may login.');

				window.location.hash = '#/';
			})
			.then(null, function (err) {
				alert(JSON.parse(err.responseText).message);
			});
	};

	var postMessage = function (title, body) {
		var message,
			sessionKey = localStorage.getItem('crowdShareSessionKey');

		message = {
			"title": title,
			"body": body
		};

		// when you have more than 3 params its better to wrap them in args object { contentType: .... , sessionKey: ... }
		httpRequest.postJSON(url + 'post', contentType, acceptType, message, sessionKey)
			.then(function (success) {
				$('#createpost-title').val(' ');
				$('#createpost-body').val(' ');
				alert('Message post!');
			})
			.then(null, function (err) {
				alert(JSON.parse(err.responseText).message);
				window.location.hash = '#/login';
			});
	};

	var getMessages = function (searchUser, searchTitleBody, postsCount) {
		var searchURL,
			searchURLUser = '',
			searchURLTitleBody = '';

		if (searchUser) {
			searchURLUser = '?user=' + searchUser;
		}

		if (searchTitleBody) {
			searchURLTitleBody = '?pattern=' + searchTitleBody;
		}

		searchURL = url + 'post' + searchURLTitleBody + searchURLUser;


		httpRequest.getJSON(searchURL, contentType, acceptType)
			.then(function (data) {
				ui.drawKendoGrid(data, postsCount);
			}, function (err) {
				alert(JSON.parse(err.responseText).message);
			}
			);
	};

	var orderData = function (by, dir, data) {
		var orderedData = _.chain(data)
			.sortBy(function (post) {
				return post[by];
			})
			.value();

		// move asc to consts
		if (dir !== "asc") {
			orderedData = orderedData.reverse();
		}

		return orderedData;
	};

	return {
		postMessage: postMessage,
		login: login,
		logout: logout,
		registerAccount: registerAccount,
		getMessages: getMessages,
		orderData: orderData
	};
});