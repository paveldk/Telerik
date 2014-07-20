(function () {
	require.config({
		paths: {
			jquery: "libs/jquery.min",
			kendo: "libs/kendo.web.min",
			handlebars: "libs/handlebars",
			underscore: "libs/underscore",
			menu: "animals/menu",
			animals: "animals/animals",
			animal: "animals/animal",
			events: "animals/events",
		}
	});

	require(["jquery", "menu", "events"], function ($, Menu) {
		var menu = new Menu($('#menu'), $('#container'));
		menu.draw();
	});
}());