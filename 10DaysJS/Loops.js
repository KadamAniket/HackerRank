'use strict';

// // Type 1
// function vowelsAndConsonants(s) {

//     var vowels = [];
//     var consonants = [];

//     var vowelsArr = ['a', 'e', 'i', 'o', 'u'];
//     var str = 'asdk';

//     for (const c of s) {
//         // if (c === 'a' || c === 'e' || c === 'i' || c === 'o' || c === 'u') {
//         if (vowelsArr.includes(c)) {
//             vowels.push(c);
//         } else {
//             consonants.push(c);
//         }
//     }

//     for (const vowel of vowels) {
//         console.log(vowel);
//     }

//     for (const consonant of consonants) {
//         console.log(consonant);
//     }

// }

// Type 2
function vowelsAndConsonants(s) {

    var vowels = 'aeiou';
    var consonants = '';

    for (const c of s) {
        if (vowels.includes(c)) {
            console.log(c);
        } else {
            consonants += c + '\n';
        }
    }

    console.log(consonants.trim());

}

vowelsAndConsonants('javascriptloops');
