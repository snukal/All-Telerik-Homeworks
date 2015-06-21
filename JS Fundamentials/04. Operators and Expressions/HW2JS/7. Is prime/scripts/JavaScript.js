var jsConsole;
var submitButton = document.getElementById('submit');
submitButton.onclick = checkPoint;

function checkPoint() {
    var number = jsConsole.readFloat('#theNumber');
    
    if (number === 1) {
        jsConsole.writeLine('This number is not prime. It is a special number!')
    }
    else {
        var primeCounter = 0;

        for (var i = 1; i < number; i++) {
            if (number % i === 0 ) {
                primeCounter++;
            }
        }
        var isPrime = true;

        if (primeCounter > 2) {
            isPrime = false;
        }
    }
    jsConsole.writeLine('The number is prime: ' + isPrime);
}