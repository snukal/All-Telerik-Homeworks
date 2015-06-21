var jsConsole,
    i,
    currentCount,
    maxCount = 0,
    sequenceStart,
    arr = [3, 2, 3, 4, 2, 2, 4];

for (i = 1, len = arr.length; i < len; i += 1) {

    if (arr[i] > arr[i - 1] && (arr[i] - arr[i-1]) === 1 ) {
        currentCount += 1;
    } else {
        currentCount = 1;
    }

    if (currentCount > maxCount) {
        maxCount = currentCount;
        sequenceStart = i + 1 - maxCount;
    }
}

jsConsole.writeLine('The maximal increasing sequence is: ');

for (i = sequenceStart; i < sequenceStart + maxCount; i += 1) {
    jsConsole.write(arr[i]);
    if (!(i === sequenceStart + maxCount - 1)) {
        jsConsole.write(', ')
    }
}
