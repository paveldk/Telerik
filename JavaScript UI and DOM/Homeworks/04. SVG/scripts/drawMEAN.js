function drawMEAN() {
	$("#the-svg").empty();
	var path, text, circle, image;

	circle = createCircle('450', '130', '60', '#3E3F37');
	svg.appendChild(circle);

	path =  createPath('M 450 110 C420 130 450 160 450 160', '#5EB14A', '#5EB14A', 'none');
  	svg.appendChild(path);

  	path =  createPath('M 450 110 C480 130 450 160 450 160', '#449644', '#449644', 'none');
  	svg.appendChild(path);

  	circle = createCircle('450', '200', '60', '#282827');
	svg.appendChild(circle);

	text = createText('405', '210', '24px', 'bold', 'Arial', '#F3F3F2', 'express')
	svg.appendChild(text);

	circle = createCircle('450', '270', '60', '#E23337');
	svg.appendChild(circle);

   	path =  createPath('M 450 250 L470 260 L450 330', '#B3B3B3', '#B63032', '2');
  	svg.appendChild(path);

	path =  createPath('M 450 250 L430 260 L450 330', '#B3B3B3', '#E23337', '2');
  	svg.appendChild(path);

    path =  createPath('M 430 310 L450 256 L470 310', '#F1F0F0', 'E23337', '3');
  	svg.appendChild(path);

  	path =  createPath('M 432 310 L450 260 L450 310Z', 'none', '#E13638', 'none');
  	svg.appendChild(path);

  	path =  createPath('M 450 310 L450 260 L468 310Z', 'none', '#B63032', 'none');
  	svg.appendChild(path);

  	circle = createCircle('450', '340', '60', '#8EC74E');
	svg.appendChild(circle);

	image = createImage('400', '315', '100', '50', 'images/node.jpg');
	svg.appendChild(image);

	text = createText('340', '150', '40px', 'bold', 'Arial', '#3E3F37', 'M')
	svg.appendChild(text);

	text = createText('340', '220', '40px', 'bold', 'Arial', '#231F20', 'E')
	svg.appendChild(text);

	text = createText('340', '290', '40px', 'bold', 'Arial', '#E23337', 'A')
	svg.appendChild(text);

	text = createText('340', '360', '40px', 'bold', 'Arial', '#8EC74E', 'N')
	svg.appendChild(text);
};