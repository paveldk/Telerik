define(["jquery", "animals", "animal", "ui", "underscore", "kendo", "handlebars"], function ($, Animals, Animal, ui) {
	'use strict';
	var animals,
		jsonCourse = localStorage.getItem('animals');

	if (jsonCourse !== null) {
		animals = getData(jsonCourse);
	}
	else {
		setData();
	}

	function getData(jsonCourse) {
		jsonCourse = JSON.parse(jsonCourse);
		var animals = new Animals();
		var animalList = jsonCourse._animals;

		for (var i = 0, len = animalList.length; i < len; i++) {
			var name = animalList[i]._name,
				species = animalList[i]._species,
				numberOfLegs = animalList[i]._numberOfLegs,
				animal = new Animal(name, species, numberOfLegs);

			animals.addAnimal(animal);
		}

		return animals;
	}

	function setData() {
		animals = new Animals();
		localStorage.setItem("animals", JSON.stringify(animals));
	}

	$('#animalSubmit').click(function () {
		var validator = $('#animal').kendoValidator().data('kendoValidator');
		$("#status").html("");

		if (validator.validate()) {
			try {
				var animal = new Animal($('#animalName').val(), $('#species').val(), $('#numberOfLegs').val());
				animals.addAnimal(animal);
				clearText([$('#animalName'), $('#species'), $('#numberOfLegs')]);
				$('#animalName').focus();
			}
			catch(err) {
				$("#status").html(err.message);
			}
		}

		localStorage.setItem("animals", JSON.stringify(animals));
	});

	function clearText(params) {
		for (var i = 0, len = params.length; i < len; i++) {
			params[i].val('');
		}
	}

	$(document).ready(function () {
		var sPath = window.location.pathname,
			sPage = sPath.substring(sPath.lastIndexOf('/') + 1),
			animalsList;
		
		if(sPage === "viewAnimals.html"){
			animalsList = animals.listAnimals();
			ui.drawKendoGrid(animalsList);
		}

		if(sPage === "groupBySpecies.html") {
			// Task 4
			animalsList = animals.listAnimals();

			var groupedAnimal = _.chain(animalsList)
				.sortBy(function(animal) {
					return Number(animal.getNumberOfLegs());
				})
				.groupBy(function(animal) {
					return animal.getSpecies();
				})
				.value(),
				result = [];

			for (var group in groupedAnimal) {
				for (var i = 0, len = groupedAnimal[group].length; i < len; i++) {
					result.push(groupedAnimal[group][i]);
				}
			}

			ui.drawKendoGrid(result);
		}

		if(sPage === "totalNumberOfLegs.html") {
			// Task 5
			animalsList = animals.listAnimals();
		
			var numberOfLegs = _.chain(animalsList)
				.reduce(function(memo, animal) {
					return memo + Number(animal.getNumberOfLegs());
				}, 0)
				.value();

			$('#numberOfLegs').html('Total number of legs is: ' + numberOfLegs);
		}
	});
});