var jsConsole;
var submitButton = document.getElementById('submit');

submitButton.onclick = checkPoint;

function checkPoint() {
    var pointX = jsConsole.readFloat('#x');
    var pointY = jsConsole.readFloat('#y');

    var isInside = ((pointX * pointX) + (pointY * pointY)) <= (5 * 5);

    jsConsole.writeLine('The point is inside the circle: ' + isInside);
}
