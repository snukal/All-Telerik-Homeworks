var jsConsole;
var submitButton = document.getElementById('submit');
submitButton.onclick = calculation;

function calculation() {
    var a = jsConsole.readFloat('#a');
    var b = jsConsole.readFloat('#b');
    var c = jsConsole.readFloat('#c');

    var x1 = -b / 2 / a - Math.pow(Math.pow(b, 2) - 4 * a * c, 0.5) / 2 / a;
    var x2 = -b / 2 / a + Math.pow(Math.pow(b, 2) - 4 * a * c, 0.5) / 2 / a;

    if (isNaN(x1) && isNaN(x2)) {
        jsConsole.writeLine('There are no real roots!');
    } else if(x1 !== x2){
        jsConsole.writeLine('The roots are: x1 = ' + x1 + ' and x2 = ' + x2);
    } else {
        jsConsole.writeLine('There is one root: x1 = x2 = ' + x1)
    }
}