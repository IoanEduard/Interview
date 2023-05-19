function welcome(isTrue) {
    if (isTrue) {
        return "yes";
    } else {
        return "no"
    }
}

welcome(true);

// 3 === 3 true, this converts type
// 3 === '3' false, this is type safe

/**
 * 
 * !=
 * !==
 * >
 * <
 * >=
 * <=
 * &&
 * ||
 */

/**
 * else if for chaining conditions, order of conditions is very important
 */

var names = ["Hole-in-hole", "Eagle", "Birdie", "Par", "Boogye", "Double Boogye", "Go-Home"];

function score(par, strokes) {
    if (strokes == 1) {
        return names[0];
    } else if (strokes <= par - 2) {
        return names[1];
    } else if (strokes == par - 1) {
        return names[2];
    } else if (strokes == par) {
        return names[3];
    } else if (strokes == par + 1) {
        return names[4];
    } else if (strokes == par + 2) {
        return names[5];
    } else if (strokes >= par + 3) {
        return names[6];
    }
}

console.log(score(5, 2))