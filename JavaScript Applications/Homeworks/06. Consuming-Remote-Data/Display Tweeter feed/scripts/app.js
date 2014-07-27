(function () {
	require.config({
		paths: {
			jquery: "libs/jquery.min",
			ui: "twitterFeed/ui",
		}
	});

	require(["ui"], function () {
	});
}());