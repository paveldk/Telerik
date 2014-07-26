define(['httpRequest', "ui"], function (httpRequest, ui) {
	// Change the URl with your own! The server might not be online!
	var url = 'http://localhost:3000/students',
		contentType = 'application/json',
		acceptType = 'application/json';

	var addStudent = function(student) {
		httpRequest.postJSON(url, contentType, acceptType, student)
			.then(showStudents());
	};

	// making Get request for students
	var showStudents = function() {
		httpRequest.getJSON(url, contentType, acceptType)
			.then(function (data) {
					ui.generateStudentList(data);
				}, function (err) {
					ui.showError("Error");
				}
			);
	};

	// Sending post request for delete
	var deleteStudent = function() {
		var deleteURL = url + '/' + $('#studentId').val();

		httpRequest.postJSON(deleteURL)
			.then(showStudents());
	};

	return {
		addStudent: addStudent,
		deleteStudent: deleteStudent,
		showStudents: showStudents
	};
});