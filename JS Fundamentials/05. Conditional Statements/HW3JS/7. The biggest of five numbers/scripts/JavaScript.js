var jsConsole;
var submitbutton = document.getElementById('submit');
submitbutton.onclick = calculation;

function calculation() {
    var firstN = jsConsole.readFloat('#a');
    var secondN = jsConsole.readFloat('#b');
    var thirdN = jsConsole.readFloat('#c');
    var fourthN = jsConsole.readFloat('#d');
    var fifthN = jsConsole.readFloat('#e');
    var arrOfNumbers = [firstN, secondN, thirdN, fourthN, fifthN];

    var biggestNumber = firstN;

    for (var i= 0; i <= arrOfNumbers.length; i++) {
        if (biggestNumber < arrOfNumbers[i]) {
            biggestNumber = arrOfNumbers[i];
        }
    }

    jsConsole.writeLine('The biggest number is: ' + biggestNumber);
}