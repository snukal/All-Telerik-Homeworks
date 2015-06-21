var jsConsole;

function getProperties(element) {
    var elements = Object.getOwnPropertyNames(element);
    elements.sort();

    jsConsole.writeLine("Element " + element.toString());
    jsConsole.writeLine("Lexicographically first: " + elements[0] +
        " and last: " + elements[elements.length - 1]);
    jsConsole.writeLine();
}