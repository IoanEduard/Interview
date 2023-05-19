var arr = ["aa", 3];

var arr2 = [];

var nested = [
    ["aaa", 2],
    ["bbb", 4]
]

var arrVal = arr[0];

arr[1] = 4;

var twodArr = [
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9]
];

// console.log(twodArr[0][1]);

twodArr[twodArr.length - 1][twodArr.length - 1] = 10;

// console.log(twodArr);
var nothing;
twodArr.push("javascript", "bro");
twodArr.push([nothing, nothing]);
// console.log(twodArr);
// twodArr.pop();
// console.log(twodArr);
twodArr.shift();
console.log(twodArr);
twodArr.unshift([0, -1, -2]);
console.log(twodArr);

/**
 * Arrays in js
 * 
 * indexing works the same 
 * push - we add at the end of the array
 * pop - we pop at the end of the array
 * shift - we remove from the start of the array
 * unshift - we add at the start of an array
 * 
 * Arrays in js are like a Stack and Queue combined with no type safety.
 */