/* Task1 : Create a module for working with DOM. The module should have the following functionality
		Add DOM element to parent element given by selector
		Remove element from the DOM  by given selector
		Attach event to given selector by given event type and event hander
		Add elements to buffer, which appends them to the DOM when their count for some selector becomes 100
		The buffer contains elements for each selector it gets
		Get elements by CSS selector
		The module should reveal only the methods
		*/

function getRandomColor() {
    var letters = '0123456789ABCDEF'.split('');
    var color = '#';
    for (var i = 0; i < 6; i++ ) {
        color += letters[Math.floor(Math.random() * 16)];
    }
    return color;
}

var domModule = (function () {
	var self,
		buffer = [];

	function appendChild(element, parent) {
		var parent = document.querySelector(parent);

		if (parent != null) {
			parent.appendChild(element);
		} else {
			console.log("No such parent element found!");
		}		
	}

	function removeChild(element, parent) {
		var parent = document.querySelector(parent),
			element = parent.querySelector(element);

		if (element != null && parent != null) {
			parent.removeChild(element);
		} else {
			console.log("Error in parent or child element");
		}		
	}

	function addHandler(element, thisEvent, thisFunction) {
		element = document.querySelector(element);

		if (element != null) {
			element.addEventListener(thisEvent, thisFunction, false)
		} else {
			console.log("No such element found!");
		}
	}

	function appendToBuffer(parent, element) {
		buffer.push({parent: parent, element: element})

		// made it with 10 to be easier to check
		if (buffer.length > 9) {
			for (var i = 0, len = buffer.length; i < len; i++) {
				var parent = document.querySelector(buffer[i].parent);

				if (parent != null) {
					parent.appendChild(buffer[i].element);
				} else {
					console.log("No such parent element found!");
				}	
			};	
			
			buffer = [];
		}
	}

	self = {
		appendChild: appendChild,
		removeChild: removeChild,
		addHandler: addHandler,
		appendToBuffer: appendToBuffer
	};

	return self;
}());	

