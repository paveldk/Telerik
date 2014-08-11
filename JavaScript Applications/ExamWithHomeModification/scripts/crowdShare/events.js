define(['jquery', 'logic'], function ($, logic) {
	var consts = {
		minLength: 6,
		maxLength: 40,

		dom: {
			login: {
				username: '#login-nickname',
				password: '#login-password'
			},

			register: {
			},

			//etc
		},

		msg: {
			incorrectData: 'Please enter correct data!'
		}
	}

	function isDataValid(username, password) {
		if (username && password && hasCorrectLength(username)) {
			return true;
		}

		return false;
	}

	function hasCorrectLength(param) {
		if (param.length < consts.minLength || param.length > consts.maxLength) {
			return false;
		}

		return true;
	}

	// lOG IN
	$(document).on("click", "#login-button", function () {
		var username = $(consts.dom.login.username).val(),
			password = $(consts.dom.login.password).val();

		if (isValidData(username, password)) {
			logic.logic(username, password)
		} else {
			alert(consts.msg.incorrectData);
		}
	});

	// REGISTER
	$(document).on("click", "#register-button", function () {
		// same as login

		var username = $('#register-nickname').val(),
			password = $('#register-password').val(),
			repeatPassword = $('#repeat-register-password').val();

		if (username.length < 6 || username.length > 40) {
			alert('Username must be between 6 and 40 symbols!');
		} else {
			if (password !== repeatPassword) {
				alert("The passwords don't match! Please enter them again!");
			} else {
				if (password && username) {
					logic.registerAccount(username, password);
				} else {
					alert('Please enter correct data!');
				}
			}
		}
	});

	// CREATE POST
	$(document).on("click", "#post-button", function () {
		var title = $('#createpost-title').val(),
			body = $('#createpost-body').val();

		if (title && body) {
			logic.postMessage(title, body);
		} else {
			alert(consts.msg.incorrectData);
		}
	});

	// GET POSTS
	$(document).on("click", "#getmessages-button", function () {
		var searchUser = $('#search-user').val(),
			searchTitleBody = $('#search-title-body').val(),
			postsCount = $('#posts-count').val();

		logic.getMessages(searchUser, searchTitleBody, postsCount);
	});

	// Get sorting
	$(document).on("click", ".k-header", function () {
		var grid = $('#grid').data("kendoGrid"),
			ds = grid.dataSource,
			sort = ds.sort();

		if (sort) {
			logic.orderData(sort[0].field, sort[0].dir, grid._data);
		}
	});
});
