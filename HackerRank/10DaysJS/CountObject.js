var arr = ['a', 'b', 'c', 'd', 'e'];

var person = {
    name: 'Aniket',
    lastName: 'Kadam',
    age: 29
}
console.log('of');
for (let ar of arr) {
    console.log(ar);
}
console.log('in');
for (let ar in arr) {
    console.log(ar);
}

for (let prop in person) {
    console.log(prop, person[prop]);
}



function getCount(objects) {
    // var count = 0;

    // for (var obj of objectList) {
    //     if (obj.x === obj.y) {
    //         count++;
    //     }
    // }

    // return count;


    return objectList.filter(obj => obj.x === obj.y).length;
}

var objectList = [
    { x: 1, y: 1 },
    { x: 1, y: 2 },
    { x: 1, y: 2 },
    { x: 1, y: 2 },
    { x: 1, y: 1 }
];

console.log(getCount(objectList));

