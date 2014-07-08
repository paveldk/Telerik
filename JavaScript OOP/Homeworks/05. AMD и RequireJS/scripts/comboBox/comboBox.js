define(["jquery"], function ($) {
    var controls = {};

	function ComboBox(items) {
		this._items = items;
	}

	ComboBox.prototype.render = function (template) {
		var peopleTemplate = Handlebars.compile(template)

		$('#people-containter').html(peopleTemplate({
			people : this._items
		}));

		var sel = $('<ul id="people-containter"/>');
		$('#people-containter div').each(function(){
		    sel.append('<li value='+ this.id +'>'+ this.innerHTML +'</li>')
		});

		$('#people-containter').replaceWith(sel);

		var $container = $('#people-containter').children();

		$container.first().addClass('selected');
		        
		return  $container; 
	};

	controls.ComboBox = function (itemsSource) {
        return new ComboBox(itemsSource);
    };

	return controls;
});