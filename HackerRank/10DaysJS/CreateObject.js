function Rectangle(a, b) {

    // return {
    //     length: a,
    //     width: b,
    //     perimeter: 2 * (a + b),
    //     area: a * b
    // }

    // var obj = new Object();
    // obj.length = a;
    // obj.width = b;
    // obj.perimeter = 2 * (a + b);
    // obj.area = a * b;

    // var obj = new RectangleObject(a, b);

    // function RectangleObject(length, width) {

    this.length = a;
    this.width = b;
    this.area = a * b;
    this.perimeter = 2 * (a + b);
    // }


    // return obj


}

console.log(Rectangle(4, 5));