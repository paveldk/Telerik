(function () {
	require.config({
		paths: {
			jquery: "libs/jquery.min",
			rsvp: "libs/rsvp.min",
			httpRequest: "httpRequest/httpRequest",
			logic: "httpRequest/logic",
			ui: "httpRequest/ui",
			events: "httpRequest/events"
		}
	});

	require(["events"], function () {
	});
}());