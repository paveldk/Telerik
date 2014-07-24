(function () {
	require.config({
		paths: {
			jquery: "libs/jquery.min",
			kendo: "libs/kendo.web.min",
			handlebars: "libs/handlebars",
			underscore: "libs/underscore",
			ui: "students/ui",
			course: "students/course",
			student: "students/student",
			events: "students/events",
		}
	});

	require(["jquery", "ui", "events"], function ($, ui) {
		ui.loadMenu('#menu', $('#container'));
	});
}());