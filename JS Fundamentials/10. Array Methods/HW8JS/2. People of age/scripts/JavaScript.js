function human(fname, lname, age, gender) {
    return {
        fname: fname,
        lname: lname,
        age: age,
        gender: gender
    }
}

function createHumans(count) {
    count = count || 8;
    var fnamesM = ['Ivkata', 'Adriankata', 'Mitaka', 'Niki', 'Pesho', 'Asen', 'Radkata'];
    var lnamesM = ['Asparuhov', 'Simeonov', 'Krumov', 'Tervelov', 'Asenov', 'Ivanov'];
    var fnamesW = ['Pepa', 'Aleksina', 'Aleksandrina', 'Svetla', 'Aleksandra', 'Elzhana', 'Elena'];
    var lnamesW = ['Georgieva', 'Petrova', 'Ivanova', 'Gikova', 'Zaharieva', 'Mindilska'];

    var humanArr = [];
    var fname,
		lname,
		age,
		gender;
    for (var i = 0; i < count; i += 1) {
        if (Math.round(Math.random())) {
            fname = fnamesM[(Math.random() * fnamesM.length) | 0];
            lname = lnamesM[(Math.random() * lnamesM.length) | 0];
            gender = 'm';
        } else {
            fname = fnamesW[(Math.random() * fnamesW.length) | 0];
            lname = lnamesW[(Math.random() * lnamesW.length) | 0];
            gender = 'f';
        }
        age = Math.random() * 100 | 0;
        humanArr.push(human(fname, lname, age, gender));
    }
    return humanArr;
}

var humanArr = createHumans(5);
console.log(humanArr);
console.log(humanArr.every(function (person) {
    return person.gender = 'f';
}))