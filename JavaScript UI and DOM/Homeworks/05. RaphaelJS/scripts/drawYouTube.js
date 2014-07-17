function drawYouTube(paper) { 
    clear(paper);

    var youText = paper.text(300, 200, 'You');
    youText.attr({
        'font-size': 100,
        'font-family' : 'Franklin Gothic Demi Condensed',
        fill : '#4B4B4B'
    });

    var rect = paper.rect(400, 145, 225, 105, 25);
    rect.attr({
        fill: 'red',
        stroke: 'red'
    });

    var tubeText = paper.text(510, 200, 'Tube');
    tubeText.attr({
        'font-size': 100,
        'font-family' : 'Franklin Gothic Demi Condensed',
        fill: 'white'
    });
};