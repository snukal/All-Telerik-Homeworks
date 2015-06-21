var jsConsole,
    submitButton = document.getElementById('submit');
submitButton.onclick = calculate;

function calculate() {
    var input = jsConsole.read('#a'),
        arr = input.split(',');
    var number = jsConsole.readInteger('#b').toString();
    var count = 0,
        i;

    for (i = 0, len = arr.length; i < len; i+=1) {
        if (number === arr[i]) {
            count++;
        }
    }
    jsConsole.writeLine('The number "' + number + '" appears ' + count + ' times in the given array!');
}
