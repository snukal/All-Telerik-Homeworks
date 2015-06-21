var jsConsole,
    submitButton = document.getElementById('submit');

submitButton.onclick = calculation;

function calculation() {
    var input = jsConsole.readInteger('#a').toString();
    var arr = input.split('');
    var lastDigit;

    lastDigit = arr[arr.length - 1];

    switch (lastDigit) {

        case '1': jsConsole.writeLine('one'); break;
        case '2': jsConsole.writeLine('two'); break;
        case '3': jsConsole.writeLine('three'); break;
        case '4': jsConsole.writeLine('four'); break;
        case '5': jsConsole.writeLine('five'); break;
        case '6': jsConsole.writeLine('six'); break;
        case '7': jsConsole.writeLine('seven'); break;
        case '8': jsConsole.writeLine('eight'); break;
        case '9': jsConsole.writeLine('nine'); break;

        default: jsConsole.writeLine('That\'s not a diggit');

    }
}