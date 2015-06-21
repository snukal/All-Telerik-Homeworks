var jsConsole;
var text = 'bal bla bla bla bla ';


function replaceNbsps(text) {

    for (var i = 0; i < text.length; i++) {
        text = text.replace(' ', '&nbsp');
    }
    return text;
}
jsConsole.writeLine(replaceNbsps(text));
jsConsole.writeLine('Please click F12 for console.log view!');
console.log(replaceNbsps(text));