var jsConsole;

    var i,
        arr = [];

    for ( i = 0; i < 20; i+=1) {
        arr[i] = i * 5;
    }

    jsConsole.writeLine('The array: ' + arr.join(', '))
