var jsConsole;
var submitButton = document.getElementById('submit');
submitButton.onclick = calculation;

function calculation() {
    var maxNumber = jsConsole.readInteger('#n'),
        number = 0;
    jsConsole.writeLine('Result: ')
    while (number <= maxNumber) {
        jsConsole.writeLine(number)
        number += 1;
    } 
}