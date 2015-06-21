var jsConsole;
var submitButton = document.getElementById('submit');
submitButton.onclick = checkPoint;

function checkPoint() {
    var a = jsConsole.readFloat('#a')
    var b = jsConsole.readFloat('#b')
    var c = jsConsole.readFloat('#c')

    if ((a>b) && (a>c))
    {
        if (b>c)
        {
            jsConsole.writeLine("Result: " + a + " " + b + " " + c);
        }
        else
        {
            jsConsole.writeLine("Result: " + a + " " + c + " " + b);
        }
    }
    else if ((a < b) && (a < c))
    {
        if (b < c)
        {
            jsConsole.writeLine("Result: " + c + " " + b + " " + a);
        }
        else
        {
            jsConsole.writeLine("Result: " + b + " " + c + " " + a);
        }
    }
    else if ((a > b) && (a < c))
    {
        jsConsole.writeLine("Result: " + c + " " + a + " " + b);
    }
    else if ((a > c) && (a < b))
    {
        jsConsole.writeLine("Result: " + b + " " + a + " " + c);
    }
        
}