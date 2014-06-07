function drawTelerik(paper) {
    clear(paper);

    var telerikLogo = paper.path('M51 117 80 90 156 180 118 214 83 174 170 90 194 118');
    // 243 63 283 23 299 39
    telerikLogo.attr({
        'stroke-width': 20,
        stroke: '#5CE600'
    });

    var rText = paper.text(690, 148, 'R');
    rText.attr({
        'font-size': 22,
        'font-weight': 'bold'
    });

    var rCircle = paper.circle(690, 148, 15);
    rCircle.attr({
        'stroke-width': 2
    });
    
    var logoText = paper.text(450, 160, 'Telerik');
    logoText.attr({
        'font-size': 140,
        'font-weight': 'bold',
        'font-family': 'Arial'
    });

    var sloganText = paper.text(532, 245, 'Develop experiences');
    sloganText.attr({
        'font-size': 60,
        'font-family': 'Arial'
    });    
}