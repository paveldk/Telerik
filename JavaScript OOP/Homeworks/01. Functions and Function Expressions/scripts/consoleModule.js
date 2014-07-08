/* Task3 : CCreate a module to work with the console object.Implement functionality for:
		Writing a line to the console 
		Writing a line to the console using a format
		Writing to the console should call toString() to each element
		Writing errors and warnings to the console with and without format
		*/

var specialConsole = (function () {
	var self;

	function writeLine(message, format) {
		if (format) {
			message = message.replace("{0}", format);
		} 
		
		console.log(message.toString());
	}

	function writeError(message, format) {
		if (format) {
			message = message.replace("{0}", format);
		} 

		console.error(message.toString());
	}

	function writeWarning(message, format) {
		if (format) {
			message = message.replace("{0}", format);
		} 
		
		console.warn(message.toString());
	}
	
	self = {
		writeLine : writeLine,
		writeError : writeError,
		writeWarning : writeWarning
	};

	return self;
}());	

