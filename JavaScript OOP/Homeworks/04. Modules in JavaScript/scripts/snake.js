var snake = (function () {
  var previousPosArray,
      posArray = [],
      direction = 'right',
      nextDirection = direction;

  posArray.push([6, 4]);
  posArray.push([5, 4]);

  var draw = function (ctx) {
    ctx.save();
    ctx.fillStyle = '#33a';
    for(var i = 0; i < posArray.length; i++) {
      drawSection(ctx, posArray[i]);
    }
    ctx.restore();
  }

  var advance = function (apple) {
    var nextPosition = posArray[0].slice();

    direction = nextDirection;
    switch (direction) {
      case 'left':
        nextPosition[0] -= 1;
        break;
      case 'up':
        nextPosition[1] -= 1;
        break;
      case 'right':
        nextPosition[0] += 1;
        break;
      case 'down':
        nextPosition[1] += 1;
        break;
      default:
        throw('Invalid direction');
    }

    previousPosArray = posArray.slice(); 
    posArray.unshift(nextPosition);
    if (isEatingApple(posArray[0], apple)) {
      apple.setNewPosition(posArray);
      game.increaseScore();
    }
    else {
      posArray.pop();
    }
  }

  var retreat = function () {
    posArray = previousPosArray;
  }

  var setDirection = function (newDirection) {
    var allowedDirections;

    switch (direction) {
    case 'left':
    case 'right':
      allowedDirections = ['up', 'down'];
      break;
    case 'up':
    case 'down':
      allowedDirections = ['left', 'right'];
      break;
    default:
      throw('Invalid direction');
    }
    if (allowedDirections.indexOf(newDirection) > -1) {
      nextDirection = newDirection;
    }
  }

  var checkCollision = function () {
    var wallCollision = false;
        snakeCollision = false,
        head = posArray[0],
        rest = posArray.slice(1),
        snakeX = head[0],
        snakeY = head[1],
        minX = 1,
        minY = 1,
        maxX = widthInBlocks - 1,
        maxY = heightInBlocks - 1,
        outsideHorizontalBounds = snakeX < minX || snakeX >= maxX,
        outsideVerticalBounds = snakeY < minY || snakeY >= maxY;

    if (outsideHorizontalBounds || outsideVerticalBounds) {
      wallCollision = true;
    }

    snakeCollision = checkCoordinateInArray(head, rest);
    return wallCollision || snakeCollision;
  }


  function drawSection (ctx, position) {
    var x = blockSize * position[0],
        y = blockSize * position[1];
    ctx.fillRect(x, y, blockSize, blockSize);
  }

  function equalCoordinates (coord1, coord2) {
    return coord1[0] === coord2[0] && coord1[1] === coord2[1];
  }

  function isEatingApple(head, apple) {
    return equalCoordinates(head, apple.getPosition());
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

  return {
    draw: draw,
    advance: advance,
    retreat: retreat,
    setDirection: setDirection,
    checkCollision: checkCollision
  };
})();