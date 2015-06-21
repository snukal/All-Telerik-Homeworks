var jsConsole,
    submitButton = document.getElementById('submit');

submitButton.onclick = calculate;

function calculate() {
    var maxNumber = jsConsole.readInteger('#n'),
        number;

    for (var number = 0; number < maxNumber; number += 1) {
        if (!!(number%21)) {
            jsConsole.writeLine(number);
        }
    }
}
