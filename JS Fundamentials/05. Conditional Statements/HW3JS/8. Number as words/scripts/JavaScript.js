var jsConsole;
var submitButton = document.getElementById('submit');
submitButton.onclick = calculate;

function calculate() {
    var number = jsConsole.readInteger('#a');
    if (number <= 0 || number >999 || isNaN(number)) {
        jsConsole.writeLine('Please, enter a correct value for A (value must be betwen 0 and 999)')
        return;
    }
    var hundreds = Math.floor( number / 100);
    var tens = Math.floor(number / 10)% 10;
    var digits = number % 10;
    var special = 10 + digits;
    var specialText = "";
    var hundredsText = "";
    var tensText = "";
    var digitsText;

    switch (special) {
        case 11:
            specialText = "eleven";
            break;
        case 12:
            specialText = "twelve";
            break;
        case 13:
            specialText = "thirteen";
            break;
        case 14:
            specialText = "fourteen";
            break;
        case 15:
            specialText = "fifteen";
            break;
        case 16:
            specialText = "sixteen";
            break;
        case 17:
            specialText = "seventeen";
            break;
        case 18:
            specialText = "eighteen";
            break;
        case 19:
            specialText = "nineteen";
            break;
    }

    switch (hundreds) {
        case 1:
            hundredsText = 'one hundred';
            break;
        case 2:
            hundredsText = 'two hundred';
            break;
        case 3:
            hundredsText = 'three hundred';
            break;
        case 4:
            hundredsText = 'four hundred';
            break;
        case 5:
            hundredsText = 'five hundred';
            break;
        case 6:
            hundredsText = 'six hundred';
            break;
        case 7:
            hundredsText = 'seven hundred';
            break;
        case 8:
            hundredsText = 'eight hundred';
            break;
        case 9:
            hundredsText = 'nine hundred';
            break;
        case 0:
            hundredsText = '';
            break;
    }
    if (number % 100 !== 0 && number >= 100) {
        hundredsText = hundredsText + ' and ';
    }
    if (tens === 1 && digits > 0) {
        jsConsole.writeLine(hundredsText + specialText);
        hundredsText = '';
        tensText = '';
    }

    switch (tens) {
        case 1:
            tensText = 'ten';
            break;
        case 2:
            tensText = 'twenty';
            break;
        case 3:
            tensText = 'thirty';
            break;
        case 4:
            tensText = 'forty';
            break;
        case 5:
            tensText = 'fifty';
            break;
        case 6:
            tensText = 'sixty';
            break;
        case 7:
            tensText = 'seventy';
            break;
        case 8:
            tensText = 'eighty';
            break;
        case 9:
            tensText = 'ninety';
            break;
        case 0:
            tensText = '';
            break;
    }

    switch (digits) {
        case 1:
            digitsText = 'one';
            break;
        case 2:
            digitsText = 'two';
            break;
        case 3:
            digitsText = 'three';
            break;
        case 4:
            digitsText = 'four';
            break;
        case 5:
            digitsText = 'five';
            break;
        case 6:
            digitsText = 'six';
            break;
        case 7:
            digitsText = 'seven';
            break;
        case 8:
            digitsText = 'eight';
            break;
        case 9:
            digitsText = 'nine';
            break;
        default:
            digitsText = '';
            break;
    }

    if (number === 0) {
        jsConsole.writeLine('Zero');
        hundredsText = '';
        tensText = '';
        digitsText = '';
    }
    if (number <= 10 || number >= 20) {
        jsConsole.writeLine(hundredsText + tensText + ' ' + digitsText);
    }
}
