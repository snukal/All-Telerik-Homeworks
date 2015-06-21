var jsConsole;
jsConsole.writeLine('Press \'F12\' and review the Console!');

function human(fname, lname, age, gender) {
    return {
        fname: fname,
        lname: lname,
        age: age,
        gender: gender
    }
}

function createPerson(count) {
    var count = count || 6,
        fnamesM = ['Ivkata', 'Adriankata', 'Mitaka', 'Niki', 'Pesho', 'Asen', 'Radkata'],
        lnamesM = ['Asparuhov', 'Simeonov', 'Krumov', 'Tervelov', 'Asenov', 'Ivanov'],
        fnamesF = ['Pepa', 'Aleksina', 'Aleksandrina', 'Svetla', 'Aleksandra', 'Elzhana', 'Elena'],
        lnamesF = ['Georgieva', 'Petrova', 'Ivanova', 'Gikova', 'Zaharieva', 'Mindilska'];

    var humanArr = [];
    var fname,
        lname,
        age,
        gender;

    for (var i = 0; i < count; i+=1) {
        if(Math.round(Math.random())) {
            fname = fnamesM[(Math.random() * fnamesM.length) | 0];
            lname = lnamesM[(Math.random() * lnamesM.length) | 0];
            gender = 'm';
        } else {
            fname = fnamesF[(Math.random() * fnamesF.length) | 0];
            lname = lnamesF[(Math.random() * lnamesF.length) | 0];
            gender = 'f';
        }
        age = Math.random() * 100 | 0;
        humanArr.push(human(fname, lname, age, gender));
    }
    return humanArr;
}
var humanArr = createPerson(5);
console.log(humanArr);
 var femaleArr = humanArr.filter(function (person) {
    return person.gender === 'f';
});

 var result = femaleArr.reduce(function (prevNum, currNum) { return prevNum + currNum.age; }, 0) / femaleArr.length;
console.log('The average age is ' +  result + ' Cheeers!');