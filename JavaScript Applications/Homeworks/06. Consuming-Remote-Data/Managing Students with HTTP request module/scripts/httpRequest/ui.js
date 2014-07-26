define(['jquery'], function () {
	var showError = function(error) {
		$("#studentsList").html('<strong>' + error + '</strong>');
	};

	// Generating DOM elements based on recieved data
	var generateStudentList = function(data) {
		var list = document.createElement('ul'),
			json = data;

		$('#studentsList').html(' ');

		for (var i = 0, len = json.count; i < len; i++) {
			var currentStudent = json.students[i],
				listItem;

			listItem = document.createElement('li');
			listItem.innerHTML = "Name: " + currentStudent.name + ', grade: ' + currentStudent.grade + ', id: ' + currentStudent.id;
			list.appendChild(listItem);
		}

		$('#studentsList').append(list);
	};

	return{
		showError : showError,
		generateStudentList : generateStudentList
	};
});