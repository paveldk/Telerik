var width = 600,
    height = 600,
    blockSize = 20,
    widthInBlocks = width / blockSize,
    heightInBlocks = height / blockSize;

var game = (function () {
  var canvas, ctx,
    frameLength,
    score,
    timeout;

  var init = function () {
    var $canvas = $('#jsSnake');

    if ($canvas.length === 0) {
      $('body').append('<canvas id="jsSnake">');
    }

    $canvas = $('#jsSnake');
    $canvas.attr('width', width);
    $canvas.attr('height', height);
    canvas = $canvas[0];
    ctx = canvas.getContext('2d');
    score = 0;
    frameLength = 200;
    bindEvents();
    gameLoop();
  }

  var increaseScore = function () {
    score++;
    frameLength *= 0.9;
  }

  function gameLoop() {
    ctx.clearRect(0, 0, width, height);
    snake.advance(apple);
    draw();

    if (snake.checkCollision()) {
      snake.retreat(); 
      snake.draw(ctx); 
      gameOver();
    }
    else {
      timeout = setTimeout(gameLoop, frameLength);
    }
  }

  function draw() {
    snake.draw(ctx);
    drawBorder();
    apple.draw(ctx);
    drawScore();
  }

  function drawScore() {
    ctx.save();
    ctx.font = 'bold 102px sans-serif';
    ctx.fillStyle = 'rgba(0, 0, 0, 0.3)';
    ctx.textAlign = 'center';
    ctx.textBaseline = 'middle';
    var centreX = width / 2;
    var centreY = width / 2;
    ctx.fillText(score.toString(), centreX, centreY);
    ctx.restore();
  }

  function gameOver() {
    ctx.save();
    ctx.font = 'bold 30px sans-serif';
    ctx.fillStyle = '#000';
    ctx.textAlign = 'center';
    ctx.textBaseline = 'middle';
    ctx.strokeStyle = 'white';
    ctx.lineWidth = 2;
    var centreX = width / 2,
        centreY = width / 2;
    ctx.strokeText('Game Over', centreX, centreY - 10);
    ctx.fillText('Game Over', centreX, centreY - 10);
    ctx.restore();
  }

  function drawBorder() {
    ctx.save();
    ctx.strokeStyle = 'gray';
    ctx.lineWidth = blockSize / 2;
    ctx.lineCap = 'square';
    var offset = ctx.lineWidth / 2,
        corners = [
          [offset, offset],
          [width - offset, offset],
          [width - offset, height - offset],
          [offset, height - offset]
        ];

    ctx.beginPath();
    ctx.moveTo(corners[3][0], corners[3][1]);
    $.each(corners, function (index, corner) {
      ctx.lineTo(corner[0], corner[1]);
    });
    ctx.stroke();
    ctx.restore();
  }
  
  function bindEvents() {
    var keysToDirections = {
      37: 'left',
      38: 'up',
      39: 'right',
      40: 'down'
    };

    $(document).keydown(function (event) {
      var key = event.which;
      var direction = keysToDirections[key];

      if (direction) {
        snake.setDirection(direction);
        event.preventDefault();
      }
    });
  }

  return {
    init: init,
    increaseScore : increaseScore
  };
})();

$(document).ready(function () {
  game.init();
});