define(["jquery", "handlebars"], function ($) {
	'use strict';
	var START_MENU_SIZE = 40;
	
	var loadMenu = function (menu, container) {
		container.load('menu.html', function() {
			$(menu).kendoMenu();
		});
	};

	function drawKendoGrid(items) {
		var lecturesTemplate = Handlebars.compile($('#students-template').html());

		$('#students-containter').html(lecturesTemplate({
			students : items
		}));

		$('#students-containter').kendoGrid({
			dataSource: {
				pageSize: 10
			},
			height: window.innerHeight - START_MENU_SIZE,
			groupable: true,
            sortable: true,
            filterable: true,
			pageable: {
                refresh: true,
                pageSizes: true,
                buttonCount: 5
            },
        });
	}

	return {
		loadMenu : loadMenu,
		drawKendoGrid :  drawKendoGrid
	};
});
