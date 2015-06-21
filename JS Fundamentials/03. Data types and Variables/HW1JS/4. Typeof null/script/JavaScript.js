var nullValued = null;
var undefinedVariable;

jsConsole.writeLine("The type of 'nullValued' is: " + typeof nullValued);
jsConsole.writeLine("The type of 'undefinedVariable' is: " + typeof undefinedVariable);


//Feedback part!!!//

var feedback = prompt("Please, rate the homework from 1 to 10!");

if (feedback >= 8 || feedback<=9) {
    jsConsole.writeLine("Thanks! That was almost perfection from my side... I'll try to work harder! I promise!");
}
else if (feedback === 10) {
    jsConsole.writeLine("Great! I'm very excited you liked my homework :))) Have a great day!");
}
else {
    jsConsole.writeLine("Well that was not quite good. I should think more for future projects! Thansk for the feedbacks ;)");
}