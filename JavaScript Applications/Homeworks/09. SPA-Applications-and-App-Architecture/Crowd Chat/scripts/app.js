(function () {
	require.config({
		paths: {
			jquery: "libs/jquery.min",
			sammy: "libs/sammy-latest.min",
			handlebars: "libs/handlebars",
			kendo: "libs/kendo.web.min",
			rsvp: "libs/rsvp.min",
			httpRequest : "crowdChat/httpRequest",
			logic: "crowdChat/logic",
			ui: "crowdChat/ui",
			events: "crowdChat/events"
		}
	});

	require(["sammy", "logic", "events"], function (sammy, logic) {
		var app = sammy("#main-content", function() {
			this.get("#/", function () {
				logic.initMainPage();
			});

			this.get("#/chat", function () {
				logic.initChatPage();
			});

			this.get("#/about", function () {
				logic.initAboutPage();
			});
		});

		app.run("#/");
	});
}());