$( document ).ready(function() {
    var books = [{
            author: 'Terry Pratchett',
            name: 'The Colour of Magic'
        }, {
            author: 'Robert Jordan',
            name: 'Wheel of time'
        }, {
            author: 'J. R. R. Tolkien',
            name: 'Lord of the rings'
        }, {
            author: 'Terry Pratchett',
            name: 'Guards! Guards! '
        }, {
            author: 'Dan Brown',
            name: 'The Da Vinci Code'
        }, {
            author: 'Dan Brown',
            name: 'Angels & Demons'
        }, {
            author: 'Terry Pratchett',
            name: 'Eric'
        }],
        maxkey,
        mostPopularAuthor;

        var mostPopular =  _.chain(books)
            .countBy(function(book) {
                return book.author;
            })
            .each(function(value, key) {
                if (maxkey === undefined || value > maxkey) {
                    maxkey = value;
                    mostPopularAuthor = key;
                }
            })
            .value();
            
    $('#mostPopularAuthor').html('The most popular autor is: ' + mostPopularAuthor);
});