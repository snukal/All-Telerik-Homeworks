var jsConsole;
var submitButton = document.getElementById('submit');
submitButton.onclick = checkPoint;

function checkPoint() {
    var number = jsConsole.readFloat('#number')
    if (!isNaN(number)) {
        switch (number) {
            case 1: jsConsole.writeLine('one'); break;
            case 2: jsConsole.writeLine('two'); break;
            case 3: jsConsole.writeLine('three'); break;
            case 4: jsConsole.writeLine('four'); break;
            case 5: jsConsole.writeLine('five'); break;
            case 6: jsConsole.writeLine('six'); break;
            case 7: jsConsole.writeLine('seven'); break;
            case 8: jsConsole.writeLine('eight'); break;
            case 9: jsConsole.writeLine('nine'); break;
            default: jsConsole.writeLine("Other number!"); break;
        }
    } else {
        jsConsole.writeLine('This is not a digit! Please reenter a number')
    }
}