var jsConsole;
var submitButton = document.getElementById('submit')

submitButton.onclick = checkpoint;

function checkpoint() {
    var valA = jsConsole.readFloat('#a')
    var valB = jsConsole.readFloat('#b')

    if (valA > valB) {
        var temp = valA
        valA = valB
        valB = temp
    }
    jsjsConsole.writeLine('The value for "A" is: ' + valA + ' and for "B" is: ' + valB)
}