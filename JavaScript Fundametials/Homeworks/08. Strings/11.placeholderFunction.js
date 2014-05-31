if (!String.format) {
    String.format = function () {
        var formattedString = arguments[0];
     
        for (var index = 0; index < arguments.length - 1; index++) {
            var regex = new RegExp("\\{" + index + "\\}", "gm");
            formattedString = formattedString.replace(regex, arguments[index + 1]);
        }
     
        return formattedString;
    };
}