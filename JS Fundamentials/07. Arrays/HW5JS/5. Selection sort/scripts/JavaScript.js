var jsConsole,
    arrayNumbers = [2, 11, 23, 5, 1, 19, 8],
    temp, i, j;

for (i = 0; i < arrayNumbers.length - 1; i += 1) {

    for (j = i + 1; j < arrayNumbers.length; j += 1) {

        if (arrayNumbers[i] > arrayNumbers[j]) {
            temp = arrayNumbers[i];
            arrayNumbers[i] = arrayNumbers[j];
            arrayNumbers[j] = temp;
        }
    }
}
jsConsole.write('Selection sorted array is: [' + arrayNumbers + ']');