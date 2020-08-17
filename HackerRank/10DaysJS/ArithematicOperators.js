function getArea(length, width) {
    let area;
    area = length * width;

    return area;
}

function getPerimeter(length, width) {
    let perimeter;
    perimeter = (2 * (length + width));

    return perimeter;
}

console.log(getArea(1000, 999.999));
console.log(getPerimeter(1000, 999.999));
