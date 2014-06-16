window.onload = function () {
	$('#dropdown').dropdown();
}

$.fn.dropdown = function () {
	var $container = $(this),
		$dropDownContainer = $('<div>').addClass("dropdown-list-container"),
		$ul = $('<ul>').addClass('dropdown-list-options')
			.css({ 'list-style-type' : 'none'}),
		$li = $('<li>').addClass('dropdown-list-option')
			.css({'background-color' : 'green',
				 'margin-bottom' : '2px',
				 'width' : '100px',
				 'height' : '25px',
				 'line-height' : '25px',
           		 'text-align': 'center'
			}),
		$label = $('<li>').addClass('dropdown-list-label').text('Select')
			.css({'background-color' : 'lightgreen',
				 'margin-bottom' : '2px',
				 'width' : '100px',
				 'height' : '25px',
				 'line-height' : '25px',
           		 'text-align': 'center'
			});

	$container.hide();

	$ul.append($label);
	for (var i = 0, len = $container.children().length; i < len; i++) {
		createNewLi($container.children()[i]);		
	};

	$ul.children().hide().first().show().on('click', function () {
    	$('.dropdown-list-option').slideToggle();
    });

	$dropDownContainer.append($ul);
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

		// $("#dropdown option:selected") is working
		$("#dropdown option:selected").removeAttr('selected');          

        $container.find(currentOption).attr('selected', 'selected');
        $label.text($selectedLi.text());

        $('.dropdown-list-options li:not(.dropdown-list-label)').slideUp('fast');
	}
}