(function () {
	require.config({
		paths: {
			jquery: "libs/jquery-1.9.1",
			kendo: "libs/kendo.web.min",
			handlebars: "libs/handlebars",
			underscore: "libs/underscore",
			events: "game/game"
		}
	});

	require(["events"], function () {
	});
}());