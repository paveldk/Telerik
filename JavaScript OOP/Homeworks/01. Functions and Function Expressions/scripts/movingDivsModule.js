/* Task2 : Create a module that works with moving div nodes. Implement functionalitcurrentY for:
		Add new moving div element to the DOM
		The module should generate random background, font and border colors for the div element
		All the div elements are with the same width and height
		The movements of the div nodes can be either circular or rectangular
		The elements should be moving all the time
		*/

function getRandomColor() {
    var letters = '0123456789ABCDEF'.split('');
    var color = '#';
    for (var i = 0; i < 6; i++ ) {
        color += letters[Math.floor(Math.random() * 16)];
    }
    return color;
}

var movingShapes = (function () {
	var self;

	function addShape(type) {
		var wrapper = document.getElementById("wrapper"),
            div = document.createElement("div");

        if (type === 'rect') {
        	div.className = "rectangle";
        	styleDiv();
            moveRect(div, 0, 0);
        } else {
        	div.className = "circle";
        	styleDiv();
            moveCirc(div, 0);
        }

        function styleDiv() {
	        div.style.backgroundColor = getRandomColor();
	        div.style.color = getRandomColor();
	        div.style.border = "1x solid " + getRandomColor();
	        div.innerText = type;
	        wrapper.appendChild(div);
        }
	}

	function moveRect(element, direction, journey) {
		var startX = 50,       
            startY = 50,       
            side = 550,    
            currentX,
            currentY;

        switch (direction % 4) {
	        case 0:
	        	currentX = startX + journey;
	            currentY = startY;        
	            break;
	        case 1:
	            currentY = startY + journey;
	            currentX = startX + side;
	            break;
	        case 2:
	            currentX = startX + side - journey;
	            currentY = startY + side;
	            break;
	        case 3:
	        	currentY = startY + side - journey;
	            currentX = startX;
	            break;
        }

        element.style.top = currentX + "px"; 
        element.style.left = currentY + "px"; 

        journey += 5;

        if (journey > side) {
            direction++;
            journey = 0;
        }

        setTimeout(function () { 
            moveRect(element, direction, journey);
        }, 20);
	}

	function moveCirc(element, angle) {
		var r = 225,               
            xCenter = 325,  
            yCenter = 325,  
            x = Math.floor(xCenter + (r * Math.cos(angle))),
            y = Math.floor(yCenter + (r * Math.sin(angle)));

        angle = angle + 0.1;
        element.style.top = x + "px"; 
        element.style.left = y + "px"; 

        setTimeout(function () { 
            moveCirc(element, angle);
        }, 20);
	}

	self = {
		add: addShape
	};

	return self;
}());	

