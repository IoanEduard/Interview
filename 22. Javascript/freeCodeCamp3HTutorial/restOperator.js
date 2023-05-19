const sum = (function() {
    return function sum(x, y, z) {
        const args = [x, y, z];
        return args.reduce((a, b) => a + b, 0);

    };
})();

console.log(sum(1, 2, 3));

const sum2 = (function() {
    return function sum(...args) {
        // const args = [x, y, z];
        return args.reduce((a, b) => a + b, 0);

    };
})();

console.log(sum2(1, 2, 3, 4, 5, 6));