class Rectangle {
    constructor(w, h) {
        this.w = w;
        this.h = h;
    }
}

    Rectangle.prototype.area=function() {
    return this.w * this.h;
}

class Square extends Rectangle {

    constructor(side) {
        super(side, side);
    }

}

console.log(new Rectangle(4, 5).area());
console.log(new Square(4).area());