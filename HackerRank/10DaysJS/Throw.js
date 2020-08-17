function isPositive(a) {
    try {
        if (a > 0) {
            return 'YES';
        }
        else if (a === 0) {
            throw Error('Zero Error');
        }
        else if (a < 0) {
            throw Error('Negative Error');
        }
    }
    catch (ex) {
        return ex.message;
    }
}

console.log(isPositive(4));
console.log(isPositive(0));
console.log(isPositive(-1));