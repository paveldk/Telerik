function clear(paper) {
	var clearRect = paper.rect(paper.x, paper.y, paper.width, paper.height);
    clearRect.attr({
        fill: 'white',
        stroke: 'white'
    });	
}
