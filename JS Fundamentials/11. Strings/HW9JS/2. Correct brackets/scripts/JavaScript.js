var jsConsole,
    submitButton = document.getElementById('submit');
submitButton.onclick = brackets;


function brackets(str) {
    var str = jsConsole.read('#a');
    var bracketOpen = '(',
        bracketClose = ')',
        countOpen = 0,
        countClose = 0,
        isCorrect,
        i;
    for (i = 0; i < str.length; i += 1) {
        if (str[i] === bracketClose) {
            countClose++;
        }
        else if (str[i] === bracketOpen) {
            countOpen++;
        }
    }
    isCorrect = countOpen === countClose;
    return jsConsole.writeLine('Is the expression corect? ' + isCorrect);
}