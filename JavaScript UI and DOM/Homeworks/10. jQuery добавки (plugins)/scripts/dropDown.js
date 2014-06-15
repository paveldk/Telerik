window.onload = function () {
	$('#dropdown').dropdown();
}

$.fn.dropdown = function () {
	var $container = $(this),
		$dropDownContainer = $('<div>').addClass("dropdown-list-container"),
		$ul = $('<ul>').addClass('dropdown-list-options'),
		$li = $('<li>').addClass('dropdown-list-option'),
		$selectedOption = $('<strong>');

	$container.hide();

	for (var i = 0, len = $container.children().length; i < len; i++) {
		createNewLi($container.children()[i]);		
	};

	$dropDownContainer.append($ul);
	$dropDownContainer.append($selectedOption);
	$('body').append($dropDownContainer);

	$dropDownContainer.find(".dropdown-list-option").on("click", function () {
			selectOption($(this));
        });

	function createNewLi(item) {
		var $currentLi = $li.clone();
		$currentLi.attr('data-value', i)
			.text(item.text);

		$ul.append($currentLi);
	}

	function selectOption(selector) {
		var $selectedLi = selector,
			option  = selector.attr('data-value'),
			currentOption = 'option[value=\'' + (parseInt(option)+1) + '\']';

    	$ul.children().css('font-weight', '');
        $container.find('.current').removeAttr('selected').removeClass('current');            

        $container.find(currentOption).attr('selected', 'selected').addClass("current");
        selector.css('font-weight', '900');

        $selectedOption.text('Selected option number ' + $container.find(currentOption).text())
        	.css('margin-left', '20px');
	}
}


