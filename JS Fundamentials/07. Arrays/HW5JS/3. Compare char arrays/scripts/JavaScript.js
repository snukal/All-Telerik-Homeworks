var jsConsole,
    i,
    currentCount,
    maxCount= 0,
    sequenceStart,
    arr = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1];

for (i = 1, len = arr.length; i < len; i+=1) {

    if (arr[i] === arr[i - 1]) {
        currentCount += 1;
    } else {
        currentCount = 1;
    }

    if (currentCount > maxCount) {
        maxCount = currentCount;
        sequenceStart = i + 1 - maxCount;
    }
}

jsConsole.writeLine('The maximal sequence of equals is: ');

for (i = sequenceStart; i < sequenceStart + maxCount; i+=1) {
    jsConsole.write(arr[i]);
    if (!(i === sequenceStart + maxCount - 1)) {
        jsConsole.write(', ')
    }
}
