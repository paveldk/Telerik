define(['./student'], function (Student) {
	'use strict';
	var Course;
	Course = (function() {
		function Course(title, formula) {
			var students = [];

			this._title = title;

			Course.prototype.addStudent = function(student) {
				if (student instanceof Student) {
					students.push(student)
				} else {
					throw new Error("Error");
				}
			}	

			Course.prototype.calculateResults = function() {
				for (var i = 0, len = students.length; i < len; i++) {
					var result = formula(students[i]);
					console.log(result);
				};			
			}

			Course.prototype.getTopStudentsByExam = function(count) {
				console.log("Top " + count + "students by exam:");
				students.sort(examCompare);

				for (var i = 0; i < count; i++) {
					console.log(students[i].name + " " + students[i].exam);
				};
			}

			Course.prototype.getTopStudentsByTotalScore = function(count) {
				console.log("Top " + count + "students by total score:");
				students.sort(totalScoreCompare);

				for (var i = 0; i < count; i++) {
					console.log(students[i].name + " " + formula(students[i]));
				};
			}

			function examCompare(a,b) {
				if (a.exam < b.exam) {
					return 1;
				}
					
				if (a.exam > b.exam) {
					return -1;
				}

				return 0;
			}

			function totalScoreCompare(a,b) {
				if (formula(a) < formula(b)) {
					return 1;
				}
					
				if (formula(a) > formula(b)) {
					return -1;
				}

				return 0;
			}


		}

		return Course;
	}());

	return Course;
});