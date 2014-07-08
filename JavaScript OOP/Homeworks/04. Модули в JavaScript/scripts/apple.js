var apple = (function () {
  var position = getRandomPosition();

  var draw = function (ctx) {
    ctx.save();
    ctx.fillStyle = '#0a0';
    ctx.beginPath();
    var radius = blockSize / 2;
    var x = position[0] * blockSize + radius;
    var y = position[1] * blockSize + radius;
    ctx.arc(x, y, radius, 0, Math.PI * 2, true);
    ctx.fill();
    ctx.restore();
  }

  var setNewPosition = function (snakeArray) {
    var newPosition = getRandomPosition();

    if (checkCoordinateInArray(newPosition, snakeArray)) {
      return setNewPosition(snakeArray);
    }
    else {
      position = newPosition;
    }
  }

  var getPosition = function() {
    return position;
  }

  function random(low, high) {
    return Math.floor(Math.random() * (high - low + 1) + low);
  }

  function getRandomPosition() {
    var x = random(1, widthInBlocks - 2),
        y = random(1, heightInBlocks - 2);
    return [x, y];
  }

  function checkCoordinateInArray (coord, arr) {
    var isInArray = false;
    $.each(arr, function (index, item) {
      if (equalCoordinates(coord, item)) {
        isInArray = true;
      }
    });
    return isInArray;
  };

  function equalCoordinates (coord1, coord2) {
    return coord1[0] === coord2[0] && coord1[1] === coord2[1];
  }

  return {
    draw: draw,
    setNewPosition: setNewPosition,
    getPosition: getPosition
  };
})();