define(['httpRequest', "ui"], function (httpRequest, ui) {
	var dataLength,
		currentPage;

	var url = 'http://crowd-chat.herokuapp.com/posts',
		contentType = 'application/json',
		acceptType = 'application/json';

	var initMainPage = function() {
		ui.initMainPage();
		currentPage = "main";
	};

	var initChatPage = function() {
		getChatFeed();
		currentPage = "chat";
	};

	var initAboutPage = function() {
		ui.initAboutPage();
		currentPage = "about";
	};

	var postMessage = function(message) {
		httpRequest.postJSON(url, contentType, acceptType, message)
			.then(getChatFeed())
			.then(getChatFeed());
	};

	var getChatFeed = function() {
		httpRequest.getJSON(url, contentType, acceptType)
			.then(function (data) {
					dataLength = data.length;
					ui.initChatPage(data);
				}, function (err) {
					ui.showError(err);
				}
			);
	};


	var refresh = setInterval(function() {
			httpRequest.getJSON(url, contentType, acceptType)
				.then(function (data) {
						if (dataLength !== data.length && currentPage === 'chat') {
							ui.setMessageFeed(data);
						}
						dataLength = data.length;
					}, function (err) {
						ui.showError(err);
					}
				);
		}, 1000);

	return {
		initMainPage: initMainPage,
		initChatPage: initChatPage,
		initAboutPage: initAboutPage,
		postMessage: postMessage
	};
});