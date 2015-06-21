var jsConsole;


var text = 'ignat@abv.bg sdsd lorem i@gmail.com ipsum Gosho_Peshev84@yahoo8.com sdd ' +
    'erererer445 kiro  moiaEmail@zamunda.net  mitkoPalauzov@gmail.c sa kiros@abv.5b';

function emailExtract(text) {
    var textArray = [], array = text.split(' '), dotIndex, indexMonkey, isCorrectEmail,
        indexDomain, indexEnd, indexUsername, regex = /\d/g;
    for (var i = 0; i < array.length; i++) {
        indexMonkey = array[i].indexOf('@');
        dotIndex = array[i].indexOf('.');
        indexDomain = dotIndex - indexMonkey - 1;
        indexEnd = array[i].length - dotIndex - 1;
        indexUsername = array[i].substring(0, indexMonkey);
        isCorrectEmail = dotIndex && indexMonkey && indexDomain > 1 && indexEnd > 1
                                  && indexUsername.length > 1 && !regex.test(array[i]);
        if (isCorrectEmail) {
            textArray.push(array[i] + ' ');
        }
    }
    return jsConsole.writeLine(textArray);
}
emailExtract(text);