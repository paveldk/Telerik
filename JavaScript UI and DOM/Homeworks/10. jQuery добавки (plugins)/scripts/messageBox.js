window.onload = function () {
	$('#success').on("click", function () {
	    var msgBox = $('#message-box').messageBox();
	    msgBox.success('Success message');
    });

    $('#error').on("click", function () {
    	var msgBox = $('#message-box').messageBox();
		msgBox.error('Error message');
    });
}

$.fn.messageBox = function () {
	var $this = $(this);

	$this.css({
		'margin-left' : 'auto',
		'margin-right' : 'auto',		
		'margin-top' : '100px',
		'width' : '20%',
		'line-height' : '50px',
		'text-align' : 'center',
		'border-radius' : '10px',
		'border' : '1px solid black'
	})

	return {
        success : function(message) {
            $this.each(function () {
                $this.css('background-color', 'green')               
               		.text(message)
               		.fadeIn(1000)
               		.delay(3000)
               		.fadeOut(1000);
            });
        },
        error : function(message){
            $this.each(function () {
                $this.css('background-color', 'red')
                	.text(message)
               		.fadeIn(1000)
               		.delay(3000)
               		.fadeOut(1000);
            });
        }
    };
}