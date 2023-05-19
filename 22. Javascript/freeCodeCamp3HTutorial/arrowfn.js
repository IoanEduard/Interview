var n = () => "arrow";

const concat = (arr1, arr2) => arr1.concat(arr2);

console.log(concat([1, 2, 3], [4, 5, 6]));

// arrow fn goes well with higher order functions such as map, filter, reduce
// they take functions as arguments for processing collections of data

const realnumbers = [4, 6.4, -9.9, 3.14, 3.44, 5];

const squareList = (arr) => {
    const squaredIntegers = arr.filter(n => Number.isInteger(n) && n > 0).map(x => x * x);
    return squaredIntegers;
}

const squaredIntegers = squareList(realnumbers);
console.log(squaredIntegers);