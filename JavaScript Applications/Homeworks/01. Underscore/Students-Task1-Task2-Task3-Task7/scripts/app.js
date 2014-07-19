(function () {
	require.config({
		paths: {
			jquery: "libs/jquery.min",
			kendo: "libs/kendo.web.min",
			handlebars: "libs/handlebars",
			underscore: "libs/underscore",
			menu: "students/menu",
			course: "students/course",
			student: "students/student",
			events: "students/events",
		}
	});

	require(["jquery", "menu", "events"], function ($, Menu) {
		var menu = new Menu($('#menu'), $('#container'));
		menu.draw();
	});
}());