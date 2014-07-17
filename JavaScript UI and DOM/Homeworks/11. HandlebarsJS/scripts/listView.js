window.onload = function() {
   var books = {
        books: [
            { id: 1, title: 'JavaScript: The good parts'},
            { id: 2, title: 'Secrets of the JavaScript Ninja'},
            { id: 3, title: 'Core HTML5 Canvas: Graphics, Animation, and Game Development'},
            { id: 4, title: 'JavaScript Patterns'},
        ]
    };

    var students = {
        students: [
            { name: 'Petar Petrov', mark: 5.5 },
            { name: 'Stamat Georgiev', mark: 4.7 },
            { name: 'Maria Todorova', mark: 6 },
            { name: 'Georgi Geshov', mark: 3.7 },
        ]
    };
    
    $('#books-list').listview(books);
    $('#studentsTable').listview(students);
    $('#studentsTableAsDiv').listview(students);
}

$.fn.listview = function (items) {
    var $this = $(this),
        templateData = $this.data('template'),
        templateSource = $('#' + templateData).html(),
        template = Handlebars.compile(templateSource);

    Handlebars.registerHelper("math", function(lvalue, operator, rvalue) {
        leftValue = parseInt(lvalue);
        rightValue = parseInt(rvalue);
            
        return {
            "+": leftValue + rightValue
        }[operator];
    });

    $this.append(template(items));
}




