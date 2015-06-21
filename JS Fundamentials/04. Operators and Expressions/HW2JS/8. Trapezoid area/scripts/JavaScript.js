var jsConsole;
var submitButton = document.getElementById('submit');
submitButton.onclick = checkpoint;

function checkpoint() {
	var aSide = jsConsole.readFloat('#a')
	var bSide = jsConsole.readFloat('#b')
	var hSide = jsConsole.readFloat('#h')

	var theMagicFormula = (aSide + bSide / 2) * hSide

	jsConsole.writeLine('The area of the trapezoid is: ' + theMagicFormula);
}