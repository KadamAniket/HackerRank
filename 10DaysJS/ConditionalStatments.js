// https://www.hackerrank.com/challenges/js10-if-else/problem

function getGrade(score) {

    // switch (true) {
    //     case (score > 25 && score <= 30):
    //         return 'A';
    //     case (score > 20 && score <= 25):
    //         return 'B';
    //     case (score > 15 && score <= 20):
    //         return 'C';
    //     case (score > 10 && score <= 15):
    //         return 'D';
    //     case (score > 5 && score <= 10):
    //         return 'E';
    //     case (score > 0 && score <= 5):
    //         return 'F';
    // }

    // if (score > 25 && score <= 30) {
    //     return 'A';
    // } else if (score > 20 && score <= 25) {
    //     return 'B';
    // }
    // else if (score > 15 && score <= 20) {
    //     return 'C';
    // }
    // else if (score > 10 && score <= 15) {
    //     return 'D';
    // }
    // else if (score > 5 && score <= 10) {
    //     return 'E';
    // } else if (score > 0 && score <= 5) {
    //     return 'F';
    // }

    return 'FFEDCBA'[Math.ceil(score / 5)];

}

console.log(getGrade(4));
console.log(getGrade(30));