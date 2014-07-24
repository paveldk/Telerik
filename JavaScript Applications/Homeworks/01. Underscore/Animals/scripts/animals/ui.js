define(["jquery"], function ($) {
	'use strict';
	var START_MENU_SIZE = 40;
	
	var loadMenu = function (menu, container) {
		container.load('menu.html', function() {
			$(menu).kendoMenu();
		});
	};

	var drawKendoGrid = function (items) {
		var lecturesTemplate = Handlebars.compile($('#animals-template').html());

		$('#animals-containter').html(lecturesTemplate({
			animals : items
		}));

		$('#animals-containter').kendoGrid({
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
	};

	return {
		loadMenu : loadMenu,
		drawKendoGrid : drawKendoGrid
	};
});
