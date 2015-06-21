var jsConsole,
    submitButton = document.getElementById('submit');

submitButton.onclick = calculate;

function calculate() {
    var input = jsConsole.read('#a'),
        n= input.split(''),
        rev = '';

    for (var i = n.length - 1; i >= 0; i--) {
        rev += n[i];
    }
    jsConsole.writeLine('Reversed number is: ' + rev);
}