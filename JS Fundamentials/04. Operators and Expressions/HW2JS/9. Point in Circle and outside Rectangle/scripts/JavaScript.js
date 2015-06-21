var jsConsole;
var submitButton = document.getElementById('submit');
submitButton.onclick = checkPoint;

function checkPoint() {
    var pointX = jsConsole.readFloat('#point-x');
    var pointY = jsConsole.readFloat('#point-y');

    var checkCircle = ((pointX - 1) * (pointX - 1)) + ((pointY - 1) * (pointX - 1)) <= 9;
    var checkRectangle = pointX < -1 || pointX > 5 || pointY < -1 || pointY > 1;

    var isInside = checkCircle && checkRectangle;

    jsConsole.writeLine('The point is inside the circle and out of the rectangle: ' + isInside);
}