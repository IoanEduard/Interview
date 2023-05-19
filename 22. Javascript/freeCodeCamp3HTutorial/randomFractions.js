function randomFractions() {
    return Math.random();
}

console.log(randomFractions());

var randomFloorNumber = Math.floor(Math.random() * 20);

function randomRange(min, max) {
    return Math.floor(math.random() * (max - min + 1)) + min;
}

randomRange(1, 9);

function convertToInteger(n) {
    var base10 = parseInt(n);
    var base2 = parseInt(n, 2);
}

// ternary operator known

function checkSign(num) {
    return num > 0 ? "positive" :
        num < 0 ? "negative" : 0;
}