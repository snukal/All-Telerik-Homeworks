var jsConsole,
    submitButton = document.getElementById('submit');
submitButton.onclick = calculate;

function getSequence() {
    var sequence = jsConsole.read('#n').split(',');
    return sequence;
}

function calculate() {
    var numbers = getSequence(),
        maxNumber = Number.MAX_VALUE,
        minNumber = Number.MIN_VALUE;

    for (var i = 0; i < numbers.length; i++) {
        if (maxNumber > +numbers[i]) {
            maxNumber = +numbers[i];
        }
        if (minNumber < +numbers[i]) {
            minNumber = +numbers[i];
        }
    }
    jsConsole.writeLine('Max number is: ' + maxNumber);
    jsConsole.writeLine('Min number is: ' + minNumber);
}