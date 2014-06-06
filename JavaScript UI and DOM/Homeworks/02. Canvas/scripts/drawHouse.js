function drawHouse(ctx){
	ctx.clearRect (0, 0 ,1800 ,1600);

	ctx.fillStyle = '#975B5B';	
	ctx.strokeStyle = '#000';
	ctx.lineWidth=2;

	ctx.fillRect(200, 200, 250, 180); // The house
	ctx.strokeRect(200, 200, 250, 180);

	drawRoof(ctx);
	ctx.save();

	drawChimney(ctx);
	ctx.restore();	

	drawWindows(ctx);

	drawDoor(ctx);
}

function drawRoof(ctx) {
	ctx.beginPath();
	ctx.moveTo(201, 199);	
	ctx.lineTo(325, 75);
	
	ctx.lineTo(449, 199);
	ctx.closePath();
	ctx.fill();
	ctx.stroke();
}

function drawChimney(ctx) {
	ctx.beginPath();
	ctx.moveTo(378, 170);	
	ctx.lineTo(378, 110);
	ctx.save();
	ctx.scale(1, 0.3)
	ctx.arc(390, 370, 12, Math.PI, 2*Math.PI);
	ctx.restore();
	ctx.lineTo(402, 110);
	ctx.lineTo(402, 170);
	ctx.fill();
	ctx.stroke();

	ctx.beginPath();
	ctx.moveTo(378, 110);
	ctx.save();
	ctx.scale(1, 0.3)
	ctx.arc(390, 370, 12, Math.PI, 2*Math.PI, true);
		
	ctx.fill();
	ctx.stroke();	
}

function drawWindows(ctx) {
	ctx.fillStyle = '#000';
	ctx.fillRect(220, 220, 40, 25);
	ctx.fillRect(262, 220, 40, 25);
	ctx.fillRect(220, 247, 40, 25);
	ctx.fillRect(262, 247, 40, 25);

	ctx.fillRect(350, 220, 40, 25);
	ctx.fillRect(392, 220, 40, 25);
	ctx.fillRect(350, 247, 40, 25);
	ctx.fillRect(392, 247, 40, 25);

	ctx.fillRect(350, 300, 40, 25);
	ctx.fillRect(392, 300, 40, 25);
	ctx.fillRect(350, 327, 40, 25);
	ctx.fillRect(392, 327, 40, 25);
}

function drawDoor(ctx) {
	ctx.moveTo(261, 380);
	ctx.lineTo(261, 300);
	
	ctx.moveTo(230, 380);
	ctx.lineTo(230, 320);
	ctx.quadraticCurveTo(230, 300, 261, 300);
	
	ctx.moveTo(292, 380);
	ctx.lineTo(292, 320);
	ctx.quadraticCurveTo(292, 300, 261, 300);
	
	ctx.moveTo(256, 350);
	ctx.arc(253, 350, 3, 0, 2*Math.PI);
	
	ctx.moveTo(272, 350);
	ctx.arc(269, 350, 3, 0, 2*Math.PI);

	ctx.stroke();
}		