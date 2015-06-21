var jsConsole;

function stringFormat(str) {
    for (var i = 0; i < 30; i++) {
        var regex = new RegExp("[{]" + i + "[}]", "gi");
        str = str.replace(regex, arguments[i + 1]);
    }
    return jsConsole.writeLine(str);
}
var format = "{0}, {1}, {0} text {2}";
var str = stringFormat(format, 1, "Pesho", "Gosho");