(function () {
	require.config({
		paths: {
			jquery: "libs/jquery.min",
			kendo: "libs/kendo.web.min",
			handlebars: "libs/handlebars",
			underscore: "libs/underscore",
			ui: "animals/ui",
			animals: "animals/animals",
			animal: "animals/animal",
			events: "animals/events",
		}
	});

	require(["jquery", "ui", "events"], function ($, ui) {
		ui.loadMenu('#menu', $('#container'));
	});
}());