define(["jquery", "course", "student", "underscore", "kendo", "handlebars"], function ($, Course, Student) {
	'use strict';
	var course,
		START_MENU_SIZE = 40,
		jsonCourse = localStorage.getItem('course');

	if (jsonCourse !== null) {
		course = getData(jsonCourse);
	}
	else {
		setData();
	}

	function getData(jsonCourse) {
		jsonCourse = JSON.parse(jsonCourse);
		var course = new Course(jsonCourse._name);
		var students = jsonCourse._students;

		for (var i = 0, len = students.length; i < len; i++) {
			var firstName = students[i]._firstName,
				lastName = students[i]._lastName,
				age = students[i]._age,
				mark = students[i]._mark,
				student = new Student(firstName, lastName, age, mark);

			course.addStudent(student);
		}

		return course;
	}

	function setData() {
		course = new Course("Javascript Aplications");
		localStorage.setItem("course", JSON.stringify(course));
	}

	$('#studentSubmit').click(function () {
		var validator = $('#student').kendoValidator().data('kendoValidator');
		$("#status").html("");

		if (validator.validate()) {
			try {
				var student = new Student($('#studentFirstName').val(), $('#studentLastName').val(),
				$('#studentAge').val(), $('#studentMark').val());
				course.addStudent(student);
				clearText([$('#studentFirstName'), $('#studentLastName'), $('#studentAge'), $('#studentMark')]);
				$('#studentFirstName').focus();
			}
			catch(err) {
				$("#status").html(err.message);
			}
		}

		localStorage.setItem("course", JSON.stringify(course));
	});

	function clearText(params) {
		for (var i = 0, len = params.length; i < len; i++) {
			params[i].val('');
		}
	}

	$(document).ready(function () {
		var sPath = window.location.pathname,
			sPage = sPath.substring(sPath.lastIndexOf('/') + 1),
			students;
		
		if(sPage === "viewStudents.html"){
			students = course.listStudents();
			drawKendoGrid(students);
		}

		if (sPage === "statisticsByName.html") {
			students = course.listStudents();

			// Task 1
			var studentsWithFirstNameBeforeLastName = _.chain(students)
				.filter(function (student) {
					return student.getFirstName() < student.getLastName();
				})
				.sortBy(function (student) {
					return student.getFirstName() + '_' + student.getLastName();
				})
				.reverse()
				.value();

			drawKendoGrid(studentsWithFirstNameBeforeLastName);
		}

		if (sPage === "statisticsByAge.html") {
			students = course.listStudents();

			// Task 2
			var studentsFilteredByAge = _.chain(students)
				.filter(function (student) {
					return student.getAge() >= 18;
				})
				.filter(function (student) {
					return student.getAge() <= 24;
				})
				.value();

			drawKendoGrid(studentsFilteredByAge);
		}

		if (sPage === "statisticsByMark.html") {
			students = course.listStudents();

			// Task 3
			var studentWithHighestMark = _.chain(students)
				.max(function (student) {
					return student.getMark();
				})
				.value(),
			result = [];

			result[0] = studentWithHighestMark;

			drawKendoGrid(result);
		}

		if (sPage === "mostCommonNames.html") {
			students = course.listStudents();

			// Task 7
			var mostCommonFirstName = _.chain(students)
				.countBy(function (student) {
					return student.getFirstName();
				})
				.pairs()
				.max(_.last)
				.head()
				.value(),
				mostCommonLastName = _.chain(students)
				.countBy(function (student) {
					return student.getLastName();
				})
				.pairs()
				.max(_.last)
				.head()
				.value();

			$('#mostCommonNames').html('The most common first name is: ' + mostCommonFirstName +
				' and the most common last name is: ' + mostCommonLastName);
		}
	});

	function drawKendoGrid(items) {
		var lecturesTemplate = Handlebars.compile($('#students-template').html());

		$('#students-containter').html(lecturesTemplate({
			students : items
		}));

		$('#students-containter').kendoGrid({
			dataSource: {
				pageSize: 10
			},
			height: window.innerHeight - START_MENU_SIZE,
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
});