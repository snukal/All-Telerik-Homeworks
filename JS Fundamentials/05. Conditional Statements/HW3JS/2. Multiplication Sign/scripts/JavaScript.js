var jsConsole;
var submitButton = document.getElementById('submit')

submitButton.onclick = checkPoint;

function checkPoint() {
    var valA = jsConsole.readFloat('#a')
    var valB = jsConsole.readFloat('#b')
    var valC = jsConsole.readFloat('#c')

    if (valA > 0 && valB > 0 && valC > 0)
    {
        jsjsConsole.writeLine("+"); 
    }
    else if ((valA > 0 && valB < 0 && valC < 0) || (valA < 0 && valB < 0 && valC > 0) || (valA < 0 && valB > 0 && valC < 0))
    {
        jsjsConsole.writeLine("+");    
    }
    else if ((valA > 0 && valB > 0 && valC < 0) || (valA > 0 && valB < 0 && valC > 0) || (valA < 0 && valB > 0 && valC > 0) || (valA < 0 && valB < 0 && valC < 0))
    {
        jsjsConsole.writeLine("-");
    }
    else if (((valA > 0 && valB > 0 && valC == 0) || (valA > 0 && valB == 0 && valC > 0) || (valA == 0 && valB > 0 && valC > 0)) || ((valA == 0 && valB > 0 && valC == 0) || (valA > 0 && valB == 0 && valC == 0) || (valA == 0 && valB == 0 && valC > 0)) || (valA == 0 && valB == 0 && valC == 0))
    {
        jsjsConsole.writeLine("0");
    }
}