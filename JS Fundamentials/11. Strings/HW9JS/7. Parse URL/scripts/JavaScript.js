var jsConsole;

var url1 = 'http://telerikacademy.com/Courses/ Courses/Details/239';
var url2 = 'ftp: // sako kukata . bg /Courses/Courses/ Details/239';

function getUrl(url) {
    var i, index, protocol, array, server, resourses;
    for (i = 0; i < url.length; i++) {
        url = url.replace(' ', '');
    }
    index = url.indexOf('//');
    protocol = url.substring(0, index - 1);
    url = url.split("//").pop();
    array = url.split('/');
    server = array[0];
    resourses = url.replace(server, '');
    return jsConsole.writeLine('Protocol: ' + protocol + '\n' + ' Server: ' + server + '\n' + ' Resourses: ' + resourses);
}
getUrl(url1);
getUrl(url2);