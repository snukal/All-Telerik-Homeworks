var jsConsole;

var text = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit' +
    ' <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';
function replaceTags(text) {
    for (var i = 0; i < text.length; i++) {
        text = text.replace('<a href', '[URL');
        text = text.replace('</a>', '[/URL]');
        text = text.replace('">', '"]');
    }
    return jsConsole.writeLine(text);
}
replaceTags(text);