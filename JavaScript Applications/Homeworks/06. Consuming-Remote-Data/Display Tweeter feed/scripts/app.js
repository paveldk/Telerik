(function () {
	require.config({
		paths: {
			jquery: "libs/jquery.min",
			ui: "twitter/ui",
		}
	});

	require(["ui"], function () {
	});
}());