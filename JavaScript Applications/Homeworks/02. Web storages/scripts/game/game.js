define(["jquery", "kendo", "handlebars", "underscore"], function ($) {
	'use strict';
	var secretNumber = [],
		numberOfAttemps = 0;

	$(document).ready(function () {
		// Hide/Show fields for start of the game
		$('.guessField').show();
		$('.results').show();
		$('.aside').show();
		$('.saveScoreField').hide();
		$('.hallOfFame').hide();

		// beautify the controls
		$("#guessButton").kendoButton();
		$("#saveScore").kendoButton();

		$("#guessField").kendoMaskedTextBox({
            mask: "0-0-0-0"
        });

		$("#playerName").kendoMaskedTextBox({
        });

		// Generate the secret number
        secretNumber = generateSecretNumber();
	});

	// Here will be the check logic
	$('#guessButton').click(function() {
		var currentAttemp = $('#guessField').val().replace(/-/gi,''),
			numberOfSheeps = 0,
			numberOfRams = 0;
		
		if (validateAttemp(currentAttemp)) {
			numberOfAttemps++;

			for (var i = 0; i < 4; i++) {
				for (var j = 0; j < 4; j++) {
					if (secretNumber[i] === Number(currentAttemp[j])) {
						if (i === j) {
							numberOfRams++;
						}
						else {
							numberOfSheeps++;
						}
					}
				}
			}

			addTry(numberOfRams, numberOfSheeps, currentAttemp);
			drawResults(numberOfRams, numberOfSheeps);
		}
		else {
			$('#guessField').val('');
			window.alert('Please enter 4 different digits!');
		}

		if (numberOfRams === 4) {
			// if the number is guessed - Show save score field
			showSaveScoreField();
		}
	});

	// Here will be the save into localStorage logic and show Hall of Fames
	$('#saveScore').click(function() {
		var playerName = $('#playerName').val(),
			playerScore = {name : playerName, attemps : numberOfAttemps},
			storedScores = localStorage.getItem('RamAndSheepScores'),
			scores = [];

		if (playerName !== '') {
			if (storedScores !== null) {
				if (JSON.parse(storedScores) instanceof Array) {
					scores = JSON.parse(storedScores);
				}
				else {
					scores.push(JSON.parse(storedScores));
				}
				
				scores.push(playerScore);
				localStorage.setItem("RamAndSheepScores", JSON.stringify(scores));
			}
			else {
				localStorage.setItem("RamAndSheepScores", JSON.stringify(playerScore));
				scores.push(playerScore);
			}
		}
		else {
			alert('Please input a name!');
		}

		$('#playerName').val('');

		shawHallOfFame(scores);
	});

	function shawHallOfFame(scores) {
		$('.saveScoreField').hide();
		$('.hallOfFame').show();

		var sortedScores = _.chain(scores)
			.sortBy(function(player) {
				return Number(player.attemps);
			})
			.value();

		drawKendoGrid(sortedScores);
	}

	// drawing KendoGrid with results
	function drawKendoGrid(items) {
		var lecturesTemplate = Handlebars.compile($('#player-template').html());

		$('#player-containter').html(lecturesTemplate({
			players : items
		}));

		$('#player-containter').kendoGrid({
			dataSource: {
				pageSize: 5
			},
			height: 340,
			groupable: true,
            sortable: true,
            filterable: true,
			pageable: {
                refresh: true,
                pageSizes: true,
                buttonCount: 5
            },
        });
	}

	// Here is the logic for non repeating user digits in the number
	function validateAttemp(attemp) {
		var used = [],
			number = Number(attemp.toString());

		for (var i = 0; i < 10; i++) {
			used[i] = 0;
		}
			
		while (Math.floor(number) !== 0) {
			if (used[Math.floor(number%10)]) {
				return 0;
			}
			
			used[Math.floor(number%10)] = 1;
			number /= 10;
		}

		return 1;
	}

	// here is the logic for generating secret number with non repeating digits
	function generateSecretNumber() {
		var number = [];

		while(number.length < 4) {
			var randomNumber = generateRandomNumber(),
				found = false;

			for (var i = 0; i < 4; i++) {
				if (number[i] === randomNumber) {
					found = true;
					break;
				}
			}

			if (!found) {
				number[number.length] = randomNumber;
			}
		}
		
		return number;
	}

	// as the name says
	function generateRandomNumber() {
		return Math.round(Math.random()*9);
	}

	// logic for showing results to the user with images for rams and sheeps
	function drawResults(rams, sheeps) {
		$('.results').html('');

		var image = $('<img>').attr('width', '150');

		for (var i = 0; i < rams; i++) {
			var ramImage = image.clone().attr('src', 'images/Ram.png');
			ramImage.appendTo($('.results'));
		}

		for (i = 0; i < sheeps; i++) {
			var sheepImage = image.clone().attr('src', 'images/sheep.png');
			sheepImage.appendTo($('.results'));
		}
	}

	function addTry(rams, sheeps, number) {
		var image = $('<img>').attr('width', '50'),
			div = $('<div>').text(number);

		for (var i = 0; i < rams; i++) {
			var ramImage = image.clone().attr('src', 'images/Ram.png');
			ramImage.appendTo(div);
		}

		for (i = 0; i < sheeps; i++) {
			var sheepImage = image.clone().attr('src', 'images/sheep.png');
			sheepImage.appendTo(div);
		}

		div.appendTo($('.aside'));

	}

	// as the name says
	function showSaveScoreField() {
		$('.guessField').hide();
		$('.results').hide();
		$('.aside').hide();
		$('#wrapper').width('100%');
		$('.saveScoreField').show();
		$('.saveScoreField .logo').text('Congratulations! You did it with ' + numberOfAttemps + ' attemps!');
	
	}
});