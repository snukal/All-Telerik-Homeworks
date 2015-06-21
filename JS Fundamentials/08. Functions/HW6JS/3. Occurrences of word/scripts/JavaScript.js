var result = document.getElementById('result'),
    submiButtonIns = document.getElementById('submitIns'),
    submiButtonSens = document.getElementById('submitSens');
var text = 'This is the text for this problem',
    word = 'this';

submiButtonIns.onclick = printIns;
submiButtonSens.onclick = printSens;
    
function printIns() {
    jsConsole.writeLine('The searched word "' + word + '" in the text |case insensitive|: ' + findOccurrences(text, word, true) + ' occurance/s')
}
function printSens() {
    jsConsole.writeLine('The searched word "' + word + '" in the text |case sensitive|: ' + findOccurrences(text, word) + ' occurance/s')
}
    

 
function findOccurrences(text, word, caseInsensitive) {
    var index = 0,
        count = 0;

    if (caseInsensitive) {
        word = word.toLowerCase();
        text = text.toLowerCase();
    }
 
    while (index !== -1) {
        index = text.indexOf(word, index);
 
        if (index !== -1) {
            index++;
            count++;
        }
    }
    return count;
}