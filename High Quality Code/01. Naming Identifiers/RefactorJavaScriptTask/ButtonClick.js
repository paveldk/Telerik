// Refactor the following examples to produce code with well-named identifiers in JavaScript

function buttonOnClick(event, arguments) {
    var myWindow = window,
        browser = myWindow.navigator.appCodeName,
        ism = browser === "Mozilla";

    if (ism) {
        alert("Yes");
    }
    else {
        alert("No");
    }
}
