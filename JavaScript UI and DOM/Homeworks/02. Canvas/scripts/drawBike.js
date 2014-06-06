function drawBike(ctx){
	ctx.clearRect (0, 0 ,1800 ,1600);

	drawGears(ctx);
	drawFrame(ctx);
}

function drawGears(ctx) {
	ctx.fillStyle = '#90CAD7';	
	ctx.strokeStyle = '#358396';
	ctx.lineWidth=1;
	ctx.lineCap = 'round';

	ctx.beginPath();		
	ctx.arc(200, 250, 50, 0, 2*Math.PI);
	ctx.moveTo(430,250);						
	ctx.arc(380, 250, 50, 0, 2*Math.PI);			
	ctx.fill();
 	ctx.stroke();	
}

function drawFrame(ctx) {
	ctx.lineWidth=2;

	ctx.beginPath();
	ctx.lineCap = 'round';
	ctx.moveTo(200,250);	// back gear point
	ctx.lineTo(260, 180);
	ctx.lineTo(360, 180);
	ctx.moveTo(380,250);	// frond gear point
	ctx.lineTo(350, 145);
	ctx.lineTo(380, 110);
	ctx.moveTo(350, 145);	// steering wheel point
	ctx.lineTo(305, 155);
	ctx.moveTo(360, 180);
	ctx.lineTo(285, 250);	
	ctx.lineTo(200, 250);
	ctx.moveTo(285, 250);	// bicycle pedals point
	ctx.lineTo(248, 160);
	ctx.moveTo(268, 160);
	ctx.lineTo(228, 160);

	ctx.moveTo(300, 250);	
	ctx.arc(285, 250, 15, 0, 2*Math.PI);	// the pedals wheel

	ctx.moveTo(296, 260);	// first pedal
	ctx.lineTo(305, 270);

	ctx.moveTo(277, 238);	// second pedal
	ctx.lineTo(266, 226);

	ctx.stroke();
}