var input = prompt("Please, enter a number!")

if ((input % 5 === 0) && (input % 7 === 0)) {
    confirm("Calculation in progress...");
    jsConsole.writeLine("The number is divisible by 7 and 5!")
}
else if ((input % 5 === 0) && !(input % 7 === 0)) {
    confirm("Calculation in progress...");
    jsConsole.writeLine("The number is divisible only by 5!")
}
else if (!(input % 5 === 0) && (input % 7 === 0)) {
    confirm("Calculation in progress...");
    jsConsole.writeLine("The number is divisible only by 7!")
}
else {
    confirm("Calculation in progress...");
    jsConsole.writeLine("The number is not divisible by 5 or 7!")
}