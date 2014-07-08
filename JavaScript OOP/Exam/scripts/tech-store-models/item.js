define(function() {
	'use strict';
	var Item;
  	Item = (function() {
	    function Item(type, name, price) {
	    	if (6 < name.length || name.length < 30) {
	    		this.name = name;
	    	}
	    	else {
	    		throw new Error('Name must be between 6 and 30 characters');
	    	}

	    	// Enum??
	    	if (type === 'accessory' || type === 'smart-phone' || type === 'notebook' || type === 'pc' || type === 'tablet') {
	    		this.type = type; 
	    	} 
	    	else {
	    		throw new Error('Incorect type');
	    	}
	      	
	      	if (isFinite(price)) {
	      		this.price = price;
	      	}
	      	else {
	      		throw new Error('Price must be numeric');
	      	}    	      	
	    }
	
    	return Item;
  	})();

  	return Item;
});