var jsConsole,
    submitButton = document.getElementById('submit');
submitButton.onclick = countStringOccuranceInText;

function countStringOccuranceInText(text, patternIn) {
    var text = jsConsole.read('#a'),
        text = text.toLowerCase(),
        patternIn = jsConsole.read('#b');
    var count = 0,
        i = 0;
    for (len = text.length; i < len; i += 1) {
        text = text.replace(patternIn, "*");
        if (text[i] === '*') {
            count++;
        }
    }
    return jsConsole.writeLine(count);
}