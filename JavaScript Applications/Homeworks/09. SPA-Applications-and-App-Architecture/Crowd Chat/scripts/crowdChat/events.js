define(['jquery', 'logic'], function ($, logic) {
	$("a").on("click", function(){
		$('.active').removeClass('active');
		$(this).parent().addClass('active');
	});

	$(document).on("click", "#sendButton", function(){
		var username = localStorage.getItem("CrowdChatUserName");
			
		var	message = {
				user : username,
				text : $('#messageBox').val()
			};
		
		logic.postMessage(message);
		$('messageBox').val(' ');
	});

	$(document).on("click", "#confirmButton", function(){
		localStorage.setItem("CrowdChatUserName", $('#nickNameBox').val());
		$('#nickNameBox').val(' ');
	});


});