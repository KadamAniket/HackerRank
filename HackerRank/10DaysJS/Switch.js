function getLetter(s) {
    // switch (s.charAt(0)) {
    //     case 'a':
    //     case 'e':
    //     case 'i':
    //     case 'o':
    //     case 'u':
    //         return 'A';

    //     case 'b':
    //     case 'c':
    //     case 'd':
    //     case 'f':
    //     case 'g':
    //         return 'B';

    //     case 'h':
    //     case 'j':
    //     case 'k':
    //     case 'l':
    //     case 'm':
    //         return 'C';

    //     case 'n':
    //     case 'p':
    //     case 'q':
    //     case 'r':
    //     case 's':
    //     case 't':
    //     case 'v': case 'w': case 'x': case 'y':
    //     case 'z':
    //         return 'D';
    // }

    switch (true) {
        case 'aeiou'.includes(s[0]):
            return 'A';

        case 'bcdefg'.includes(s[0]):
            return 'B';

        case 'hjklm'.includes(s[0]):
            return 'C';

        default:
            return 'D';
    }
}

console.log(getLetter('adfgt'));