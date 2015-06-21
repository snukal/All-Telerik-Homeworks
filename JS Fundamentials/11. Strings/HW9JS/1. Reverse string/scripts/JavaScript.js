var jsConsole,
    submitButton = document.getElementById('submit');
submit.onclick = reverseIt;

function reverseIt(str) {
    var str = jsConsole.read('#a');
    var revStr = [],
        i;

    for (i = 0, len = str.length; i <= len; i+=1) {
        revStr.push(str.charAt(len - i));
    }
    jsConsole.writeLine('The reversed string is: ' + revStr.join(''));
    return revStr;
}