var jsConsole;
var submitButton = document.getElementById('submit');

submitButton.onclick = checkPoint;

function checkPoint() {
    var valA = jsConsole.readFloat('#a')
    var valB = jsConsole.readFloat('#b')
    var valC = jsConsole.readFloat('#c')

    var biggest;
    if (valA != valB != valC) {
        if (valA > valB && valA > valC) {
            biggest = valA;
        } else if (valA < valB && valB > valC) {
            biggest = valB;
        } else {
            biggest = valC;
        }
    }
    jsjsConsole.writeLine('The biggest number is: ' + biggest)
}