var jsConsole;

var text = '<div><!DOCTYPE html><htmla <head lang="en"> <meta charset="UTF-8"> <title>Aide zavurshihmeee!</title> </head>' +
    +' <body> <div>asen</div> <div>ivan</div> <p>pesho</p> </script>  ';


removeTags(text);

function removeTags(text) {
    for (var j = 0; j < text.length; j++) {
        var indexStart = text.indexOf('<');
        var indexEnd = text.indexOf('>');
        text = (text.replace(text.substring(indexStart, indexEnd + 1), ''));
    }
    return jsConsole.writeLine(text);   
}

