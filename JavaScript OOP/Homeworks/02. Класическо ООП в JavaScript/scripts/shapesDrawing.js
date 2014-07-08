/* Task1 : Create a module for drawing shapes using Canvas. Implement the following shapes:
		Rect, by given position (X, Y) and size (Width, Height)
		Circle, by given center position (X, Y) and radius (R)
		Line, by given from (X1, Y1) and to (X2, Y2) positions
		*/

var draw = function (id) {	
	var self,
		canvas = document.getElementById(id),
		ctx = canvas.getContext("2d");

	function drawRect(x, y, width, height) {
		ctx.rect(x, y, width, height);
		ctx.stroke();
	}

	function drawCircle(x, y, r) {
		ctx.beginPath();
		ctx.arc(x, y, r, 0, 2 * Math.PI, false);
		ctx.stroke();
	}

	function drawLine(x1, y1, x2, y2) {
		ctx.beginPath();
        ctx.moveTo(x1, y1);
        ctx.lineTo(x2, y2);
        ctx.stroke();
	}

	self = {
		rect: drawRect,
		circle: drawCircle,
		line: drawLine
	};

	return self;
};	

