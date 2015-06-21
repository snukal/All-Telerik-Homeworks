var jsConsole;
//You kan manipulate the result by changing arrays content!
var Arr1 = ['k', 'o', 'r'],
    Arr2 = ['k', 'i', 'r'],
    biggestArr,
    i,
    n = 0,
    m = 0,
    symbOne,
    symbTwo;

jsConsole.writeLine('Array1: ' + Arr1);
jsConsole.writeLine('Array2: ' + Arr2);

if (Arr1.length > Arr2.length) {
    biggestArr = Arr1.length;
} else if (Arr2.length > Arr1.length) {
    biggestArr = Arr2.length;
} else {
    biggestArr = Arr1.length;
}

for (i = 0; i < biggestArr; i += 1) {

    symbOne = Arr1[i];
    symbTwo = Arr2[i];

    if (symbOne !== symbTwo) {
        if (symbOne > symbTwo) {
            jsConsole.writeLine('Oops ' + '"' + symbOne + '"' + ' is before ' + '"' + symbTwo + '". So... Array1 is before Array2!');
        } else {
            jsConsole.writeLine('Oops ' + '"' + symbTwo + '"' + ' is before ' + '"' + symbOne + '". So... Array2 is before Array1!');
        }
    }

}
