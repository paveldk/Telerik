define(['jquery', 'logic'], function ($, logic) {
	// Adding student on click by making post request
	$('#addStudent').click(function () {
		var student = {
				name : $('#studentName').val(),
				grade : $('#studentGrade').val()
			};
		logic.addStudent(student);
	});

	// Showing all students in list
	$('#showStudents').click(function () {
		logic.showStudents();
	});

	// Deleting students on click
	$('#deleteStudent').click(function () {
		logic.deleteStudent();
	});
});