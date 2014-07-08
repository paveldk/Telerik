define(["jquery"], function ($) {
	var open = function (controler) {
	    controler.children().show();
	    controler.css("overflowY", "scroll");
	}

	var select = function (controler, current) {
	    controler.parent().children().hide();
	    current.html(controler.html());
	    controler.parent().css("overflowY", "");
	}

    return {
    	open : open,
    	select : select
    }
});