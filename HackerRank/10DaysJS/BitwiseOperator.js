function getMaxLessThanK(n, k) {
    let max_anb = 0;
    for (let b = n; b > 0; b--) {
        for (let a = b - 1; a > 0; a--) {
            if ((a & b) < k && (a & b) > max_anb) {
                max_anb = (a & b);
            }
        }
    }
    return max_anb;
}

function base10ToBase2(num) {
    var base2 = '';

    while (num !== 0) {
        base2 += '' + (num % 2);
        num = Math.floor(num / 2);
    }

    return base2.split('').reverse().join('');
}

function base2ToBase10(num) {
    var base10 = 0;
    var numArr = num.split('').reverse();
    for (var i = 0; i < numArr.length; i++) {
        base10 += (+numArr[i] * Math.pow(2, i));
    }

    return base10;
}

// console.log(base10ToBase2(129));
// console.log(base10ToBase2(71));
// console.log(base10ToBase2(8));
// console.log(base10ToBase2(9));

// console.log(base2ToBase10('1001'));
// console.log(base2ToBase10('1000'));
// console.log(base2ToBase10('1000111'));
// console.log(base2ToBase10('10000001'));

console.clear();

console.log(getMaxLessThanK(9, 2));
