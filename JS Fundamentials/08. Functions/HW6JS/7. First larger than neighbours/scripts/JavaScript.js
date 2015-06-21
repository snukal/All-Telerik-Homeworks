var jsConsole,
    submitButton = document.getElementById('submit');
submitButton.onclick = calculate;

function calculate(arr) {
    var input = jsConsole.read('#a'),
        arr = input.split(',');
    var position,
        condition = false;

    for (position = 1, len = arr.length ; position < len; position += 1) {
        condition = false;
        if (position > 0) {
            if (arr[position] > arr[position - 1]) {
                condition = true;
            }
        }

        if (position < arr.length - 1) {
            if (arr[position] > arr[position + 1]) {
                condition = condition && true;
            } else {
                condition = condition && false;
            }
        }
        if (arr.length === 1) {
            condition = false;
        }
        if (condition) {
            jsConsole.writeLine('The first larger number with neighbours si at position ' + position + ' and it\'s value is ' + arr[position]);
            return position;
        }
    }
    if (!condition) {
        jsConsole.writeLine('-1');
        return -1;
    }
}