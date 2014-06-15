// Create the following using Handlebars.js. Dates are all the same, but I don't think it's a problem

window.onload = function () {
	var lectures = [{
			number: 0,
			name: 'Course introduction',
			firstDate: 'Wed 18:00 28-May-2014',
			secondDate: 'Wed 18:00 28-May-2014'
		}, {
			number: 1,
			name: 'Document Object Model',
			firstDate: 'Wed 18:00 28-May-2014',
			secondDate: 'Wed 18:00 28-May-2014'
		}, {
			number: 2,
			name: 'HTML5 Canvas',
			firstDate: 'Wed 18:00 28-May-2014',
			secondDate: 'Wed 18:00 28-May-2014'
		}, {
			number: 3,
			name: 'HTML5 Canvas библиотеки - KineticJS',
			firstDate: 'Wed 18:00 28-May-2014',
			secondDate: 'Wed 18:00 28-May-2014'
		},{
			number: 4,
			name: 'SVG',
			firstDate: 'Wed 18:00 28-May-2014',
			secondDate: 'Wed 18:00 28-May-2014'
		}, {
			number: 5,
			name: 'Raphael за работа с SVG',
			firstDate: 'Wed 18:00 28-May-2014',
			secondDate: 'Wed 18:00 28-May-2014'
		}, {
			number: 6,
			name: 'Анимации с Canvas и SVG',
			firstDate: 'Wed 18:00 28-May-2014',
			secondDate: 'Wed 18:00 28-May-2014'
		}, {
			number: 7,
			name: 'Операции с DOM',
			firstDate: 'Wed 18:00 28-May-2014',
			secondDate: 'Wed 18:00 28-May-2014'
		}, {
			number: 8,
			name: 'Модел на събития в JavaScript',
			firstDate: 'Wed 18:00 28-May-2014',
			secondDate: 'Wed 18:00 28-May-2014'
		}, {
			number: 9,
			name: 'Основи на jQuery',
			firstDate: 'Wed 18:00 28-May-2014',
			secondDate: 'Wed 18:00 28-May-2014'
		}, {
			number: 10,
			name: 'jQuery добавки (plugins)',
			firstDate: 'Wed 18:00 28-May-2014',
			secondDate: 'Wed 18:00 28-May-2014'
		}, {
			number: 11,
			name: 'Шаблони за HTML (Handlebars.js)',
			firstDate: 'Wed 18:00 28-May-2014',
			secondDate: 'Wed 18:00 28-May-2014'
		}, {
			number: 12,
			name: 'Подготовка за изпит',
			firstDate: 'Wed 18:00 28-May-2014',
			secondDate: 'Wed 18:00 28-May-2014'
		}, {
			number: 12,
			name: 'Отборна работа',
			firstDate: 'Wed 18:00 28-May-2014',
			secondDate: 'Wed 18:00 28-May-2014'
		}, {
			number: 12,
			name: 'Изпит',
			firstDate: 'Wed 18:00 28-May-2014',
			secondDate: 'Wed 18:00 28-May-2014'
		}];

	lecturesContainer = document.getElementById('lectures-containter');

	lecturesTemplate = Handlebars.compile((document.getElementById('lectures-template')).innerHTML);

	lecturesContainer.innerHTML = lecturesTemplate({
		lectures : lectures
	});
}