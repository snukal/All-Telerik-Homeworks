var strOne = "<u>Slavka Kalcheva sings:</u> \"Bqla roza shte zakicha...\"<br> ";
var emptyLine = "<br>";
var strTwo = "<br><u>Eminem sings:</u> 'Cause Im Slim Shady, yes I'm the real Shady'<br>";

jsConsole.writeLine(strOne + emptyLine + "<b><i><---OR---></i></b>" + emptyLine + strTwo);

var resChoise = prompt("Choose what to play! (Slavka or Eminem)")

if (resChoise === "Slavka" ) {
    jsConsole.writeLine("... na kapaka na Moskvichaaaaa :)))");
}
else {
    jsConsole.writeLine("...Please stand up, please stand up?")
}