// Increment Then Return
var counter = function(n) {
    let currentCount = n - 1;
    console.log(`Outer currentCount: ${currentCount}`)
    return function() {
        currentCount += 1;
        console.log(`Inner currentCount: ${currentCount}`)
        return currentCount;
    }
}
var count = counter(6);
console.log(count());

var postfixCounter = function(n) {
    return function() {
        return n++;
    }
}

var postfixArrow = () => n++;

var prefixDecrementAndIncrement = function(n) {
    --n;
    return function() {
        return ++n;
    }
}