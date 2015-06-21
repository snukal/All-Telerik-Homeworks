var jsConsole,
    submitButton = document.getElementById('submit');
submitButton.onclick = calculate;

function calculate(arr, position) {
    var input = jsConsole.read('#a'),
        arr = input.split(','),
        position = jsConsole.readInteger('#b');
    var condition = false;

    if (arr.lenght === 1 || position === 0 || position === arr.lenght - 1) {
        jsConsole.writeLine('The number at position ' + position + ' don\'t have neighbours!');
        return condition;
    }
    if (position > 0) {
        if (arr[position] > arr[position -1]) {
            condition = true;
        }
    }
    if (position < arr.lenght - 1) {
        if(arr[position] > arr[position + 1]) {
            condition = condition && true;
        } else {
            condition = condition && false;
        }
    }
    if (condition) {
        jsConsole.writeLine('The number at position ' + position + ' have neighbours and it is bigged than them!');
    } else {
        jsConsole.writeLine('The number at position ' + position + ' don\'t have neighbours!');
    }
    
}