/*Create a slider control using jQuery
	The slider can have many slides
	Only one slide is visible at a time
	Each slide contains HTML code
	i.e. it can contain images, forms, divs, headers, links, etc…
	Implement functionality for changing the visible slide after 5 seconds
	Create buttons for next and previous slide
*/
window.onload = function (){
	var slider = $("#slider"),
		slides = [],
		width = $(document).width(),
    	height = $(document).height(),
		previousButton = $("<img></img>")
			.attr('id', 'previous')
			.attr('src', 'images/prev.png')
			.on('click', PreviousClick)
			.css({
				height : '50px',
				width : '50px',
			  	position : 'relative',
			   	left : '50px',
			   	top : height / 2
			}),
		nextButton = $("<img></img>")
	    	.attr('id', 'next')   	
	    	.attr('src', 'images/next.png')
	    	.on('click', NextClick)
	    	.css({
				height : '50px',
				width : '50px',
				position : 'relative',
				left : width - 150,
				top : height / 2
			}),
    	current,
    	currentElement = 0,
    	time = 5000;


    $("body").prepend(nextButton);
    $("body").prepend(previousButton);
    

	AddSlide("<p> Paragraph test </p>");
	AddSlide("<div> Div test </div>");
	AddSlide("<h1> Header test </h1>");
	AddSlide("<image src='images/next.png'>");

	slider.append(slides).children().hide().css({
		'text-align' : 'center'
	});;

	slider.css({
		'margin-left' : 'auto',
		'margin-right' : 'auto',
		'margin-top' : height / 2 - 30,
		'width' : "20%"
	});

	current = slider.children().first();
	current.show();

	function AddSlide(slide) {
		slides.push(slide);
	}

	function PreviousClick() {
		current.hide();
		if (currentElement > 0) {
			current = current.prev().show();
			currentElement--;
		} else {
			current = slider.children().last().show();
			currentElement = slides.length - 1;
		}	
	}

	function NextClick() {
		current.hide();
		if (currentElement < slides.length - 1) {			
			current = current.next().show();
			currentElement++;
		} else {		
			current = slider.children().first().show();
			currentElement = 0;
		}	
	}

	window.setInterval(function(){NextClick()}, time);
}