class Polygon {

    constructor(arr) {
        this.sides = arr;
    }

    perimeter() {
        var perimeter = 0;
        this.sides.forEach(m => perimeter += m);
        return perimeter;
    }
}

// function Polygon(sides) {
//     this.sides = sides;
//     this.perimeter = function () {
//         var perimeter = 0;
//         this.sides.forEach(m => perimeter += m);
//         return perimeter;
//     }
// }



let triangle = new Polygon([3, 4, 5]);

console.log(triangle.perimeter());