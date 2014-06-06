function drawGentleman(ctx){
	ctx.clearRect(0, 0, 1800, 1600);
	 
	drawHead(ctx);
	ctx.save();	

	drawEyes(ctx);
	ctx.restore();
	ctx.save();

	drawRetinas(ctx);
	ctx.restore();
	ctx.save();	

	drawMouth(ctx);
	ctx.restore();
	ctx.save();

	drawNose(ctx);
	ctx.restore();
	ctx.save();

	drawCylinder(ctx);
	ctx.restore();
}

function drawHead(ctx) {
	ctx.fillStyle = '#90CAD7';	
	ctx.strokeStyle = '#201D1D';
	ctx.lineWidth=1;

	ctx.beginPath();		
	ctx.arc(200, 200, 50, 0, 2*Math.PI);
	ctx.fill();
	ctx.stroke();	 
}

function drawEyes(ctx) {
	ctx.lineWidth=2;

	ctx.scale(1, 0.6)
	ctx.beginPath();
	ctx.arc(170, 310, 10, 0, 2*Math.PI);
	ctx.fill();
	ctx.stroke();

	ctx.beginPath();
	ctx.arc(210, 310, 10, 0, 2*Math.PI);
	ctx.fill();
	ctx.stroke();
}

function drawRetinas(ctx) {
	ctx.fillStyle = '#201D1D';	
	ctx.scale(0.6, 1) 

	ctx.beginPath();
	ctx.arc(278, 186, 4, 0, 2*Math.PI);
	ctx.fill();
	ctx.stroke();

	ctx.beginPath();
	ctx.arc(344, 186, 4, 0, 2*Math.PI);
	ctx.fill();
	ctx.stroke();
}

function drawMouth(ctx) {
	ctx.rotate(8 * Math.PI/180);
	ctx.scale(1, 0.3) 

	ctx.beginPath();
	ctx.arc(220, 660, 20, 0, 2*Math.PI);
	ctx.fill();
	ctx.stroke();			
}

function drawNose(ctx) {
	ctx.beginPath();
	ctx.moveTo(190, 210);
	ctx.lineTo(180, 210);
	ctx.lineTo(190, 190);
	ctx.stroke();				
}

function drawCylinder(ctx) {
	ctx.fillStyle = '#396693';
	ctx.save();		
	ctx.scale(1, 0.2) 

	ctx.beginPath();		
	ctx.arc(195, 800, 55, 0, 2*Math.PI);
	ctx.fill();
	ctx.stroke();

	ctx.restore();
	ctx.save();
	ctx.scale(1, 0.4) 
	
	ctx.beginPath();		
	ctx.arc(200, 380, 30, 0, Math.PI);	
	ctx.lineTo(170,250);	
	ctx.arc(200, 250, 30, Math.PI, 2*Math.PI);
	ctx.lineTo(230,380);
	ctx.fill();
 	ctx.stroke();	

 	ctx.beginPath();			
	ctx.arc(200, 250, 30, 2*Math.PI, Math.PI);
	ctx.fill();
	ctx.stroke();
}