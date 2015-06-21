function createPerson(name, age) {
    return {
        name: name,
        age: age
    }
}

var humans = [createPerson('Ivan', 12),
createPerson('Pesho', 12),
createPerson('Tarikat', 19)];
console.log(humans)
console.log(humans.filter(function (person) { return person.age < 18; }));