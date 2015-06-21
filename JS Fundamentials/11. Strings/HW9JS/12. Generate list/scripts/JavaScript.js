var people = [{ name: 'Zapriyan Tuhlarev  ', age: 25, hair: '  black ', sex: ' M ' },
    { name: 'Keremidka Chervnkova ', age: 20, hair: '  blonde ', sex: ' F ' }];
var tmpl = document.getElementById('list-item');
var t = 0;
var result = '<ul id="' + tmpl.id + '">';
for (var i = 0; i < people.length; i++) {
    result += '<li>';
    for (var child in people[i]) {
        result += '<' + tmpl.children[t].tagName.toLowerCase() + '>';
        result += people[i][tmpl.children[t].innerHTML.replace(/[-][{]/gi, '').replace(/[}][-]/gi, '')];
        result += '</' + tmpl.children[t++].tagName.toLowerCase() + '>';
    }
    result += '</li>';
}
result += '</ul>';
tmpl.innerHTML = result;