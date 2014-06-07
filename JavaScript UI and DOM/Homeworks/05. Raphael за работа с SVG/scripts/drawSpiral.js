function drawSpiral(paper) {
    clear(paper);

	var maxRadius = 200;

    drawRounds(500, 310, 18, 0, 0);

    function drawRounds(cx, cy, r, startAngle, endAngle) {
        while (r < maxRadius) {
            arc(cx, cy, r, startAngle, endAngle);

            r += 0.3;
            var temp = startAngle;
            startAngle = endAngle;
            endAngle = temp + 5;
        }
    }

    function arc(cx, cy, r, startAngle, endAngle) {
        var radian = Math.PI / 180,
        	startX = cx + r * Math.cos(-startAngle * radian),         
            startY = cy + r * Math.sin(-startAngle * radian),
            endX = cx + r * Math.cos(-endAngle * radian),
            endY = cy + r * Math.sin(-endAngle * radian);

        paper.path(["M", startX, startY, "A", r, r, 0, 0, 0, endX, endY]);
    }
}