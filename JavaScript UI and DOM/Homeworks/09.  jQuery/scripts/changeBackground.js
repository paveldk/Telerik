/*Implement functionality to change the background color of a web page
i.e. select a color from a color picker and set this color as the background color of the page*/
window.onload = function (){
	$("#setBackground").on('click', setBackGround);

	function setBackGround() {
		 $("body").css("background-color", $("#colorPicker").val());
	}
}
