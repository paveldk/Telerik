// Using jQuery implement functionality to insert a DOM element before or after another element
window.onload = function (){
	prepButton.addEventListener("click", function () {
			insertBefore();
		}, false);

	appButton.addEventListener("click", function () {
			insertAfter();
		}, false);
}
function insertBefore () {
	$("#the-div").prepend("<div>Inserted before</div>");
}

function insertAfter () {
	$("#the-div").append("<div>Inserted after</div>");
}