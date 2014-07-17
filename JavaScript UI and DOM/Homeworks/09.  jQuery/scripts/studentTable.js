/*By given an array of students, generate a table that represents these students
	Each student has first name, last name and grade
	Use jQuery
*/
window.onload = function (){
	var students = [
		    {
		        firstName: 'Peter',
		        lastName: 'Ivanov',
		        grade: '3'
		    },
		    {
		        firstName: 'Milena',
		        lastName: 'Grigorova',
		        grade: '6'
		    },   
		    {
		        firstName: 'Gergana',
		        lastName: 'Borisova',
		        grade: '12'
		    },
		    {
		        firstName: 'Boyko',
		        lastName: 'Petrov',
		        grade: '7'
		    }
		];

	function generateTable(list) {
		var table = $('<table></table>').css({
					'border' : '1px solid black',
					'border-collapse' : 'collapse',
					'margin' : '10px'	
				}),
			row = $('<th>First name</th><th>Last name</th><th>Grade</th>').css({
					'border' : '1px solid black',
					'border-collapse' : 'collapse',
					'padding' : '5px'		
				}),
			data;

		table.append(row);

		for(i = 0, len = list.length; i<len; i++){
		    row = $('<tr></tr>');

		    data = $('<td>' + list[i].firstName +'</td><td>' + list[i].lastName + '</td><td>' + list[i].grade + '</td>').css({
					'border' : '1px solid black',
					'padding' : '5px'
				});
		    row.append(data);
				
		    table.append(row);
		}

		$('body').append(table);	
	}

	generateTable(students);
}