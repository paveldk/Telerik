define(function() {
	'use strict';
	var Animal;
	Animal = (function() {
		function Animal(name, species, numberOfLegs) {
			if (validateData(name, "string")) {
				this._name = name;
			}

			if (validateData(species, "string")) {
				this._species = species;
			}

			if (validateData(numberOfLegs, "number")) {
				this._numberOfLegs = numberOfLegs;
			}
		}

		Animal.prototype.getSpecies = function () {
			var species = this._species;
			return species;
		};

		Animal.prototype.getNumberOfLegs = function () {
			var numberOfLegs = this._numberOfLegs;
			return numberOfLegs;
		};
		
		function validateData(item, type) {
			if (typeof item === type || isFinite(item)) {
				return true;
			}
			else {
				throw new Error(item + " must be a " + type + " variable");
			}
		}
	
		return Animal;
	})();

	return Animal;
});