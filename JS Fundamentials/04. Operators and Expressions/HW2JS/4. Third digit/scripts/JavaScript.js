var input = prompt("Please, enter a number!")

if (((input / 100)|0) % 10 === 7) {
    confirm("Calculating in progress...")
    jsConsole.writeLine("The third digit is 7!");
}
else {
    confirm("Calculating in progress...")
    jsConsole.writeLine("The third digit is not 7!");
}