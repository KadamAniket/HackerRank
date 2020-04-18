function reverseString(s) {
    try {
        console.log(s.split('').reverse().join(''));
    }
    catch (ex) {
        console.log(ex.message);
        console.log(s);
    }
}

console.log(reverseString('abcdef'));
console.log(reverseString('1234'));
console.log(reverseString(Number(1234)));