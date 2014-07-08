(function () {
	require.config({
		paths: {
			handlebars : "libs/handlebars.min",
			jquery: "libs/jquery-2.0.3.min",
			data: "app/data",
	        controls: "app/controls"		
		}
	});

	require(["jquery", "comboBox/comboBox", "handlebars", "comboBox/events"], function ($, controls, handlebars, events) {
		var people = [
				  { id: 1, name: "Doncho Minkov", age: 18, avatarUrl: "images/minkov.png" }, 
				  { id: 2, name: "Georgi Georgiev", age: 19, avatarUrl: "images/joreto.jpg" },
				  { id: 3, name: "Doncho Minkov twin", age: 19, avatarUrl: "images/minkov.png" },
				  { id: 4, name: "Georgi Georgiev twin", age: 19, avatarUrl: "images/joreto.jpg" }
			  ],
			comboBox = controls.ComboBox(people),
			$template = $("#person-template").html(),
			comboBoxHtml = comboBox.render($template),
			$container = $("#people-containter"),
			$current = $(".current-selected");

		$container.html(comboBoxHtml);
		$current.html($container.children().first().html());

	    $container.on("click", "li", function () {
    		events.select($(this), $current);	
		});

		$current.on("click", function () {
			 events.open($container);
		});
	});
}());