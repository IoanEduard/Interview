var voxel = { x: 3.4, y: 4.5, z: 6.77 };

// old way
var x = voxel.x;
var y = voxel.y;
var z = voxel.z;

// new way
const { x: a, y: b, z: c } = voxel;

const AVG_TEMPERATURES = {
    today: 88.5,
    tomorrow: 89
}

function getTemperaturesOfTomorrow(avgTemperatures) {
    "use strict";

    const { tomorrow: tempOfTomorrow } = avgTemperatures;

    return tempOfTomorrow;
}

// console.log(getTemperaturesOfTomorrow(AVG_TEMPERATURES));

// nested Objects
const LOCAL_FORECAST = {
    today: { min: 23, max: 53 },
    tomorrow: { min: 13, max: 73 },
};

function getMaxOfTomorrow(forecast) {
    "use strict";

    // maxOfTomorrow is the variable we get after destructuring
    const { tomorrow: { max: maxOfTomorrow } } = forecast;

    return maxOfTomorrow
}

// console.log(getMaxOfTomorrow(LOCAL_FORECAST));

let [zz, xx, , yy] = [1, 2, 3, 4, 5, 6];
// console.log(zz, xx, yy); // 1 2 4

let var1 = 8;
let var2 = 6;

(() => {
    "use strict";
    [zz, xx] = [xx, zz] //switching values
})();

const source = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

function removeFirstTwo(list) {
    const [, , ...arr] = list;

    return arr;
}

const arr = removeFirstTwo(source);
console.log(arr);
console.log(source);

//destructuring assigment to pass a fn param

const stats = {
    max: 56.33,
    standard_deviation: 5.55,
    median: 34.22,
    mode: 23.1,
    min: 11.11,
    avg: 10
}

const half = (function() {
    return function half({ max, min }) { // destructured
        return (max, min) / 2.0;
    }
})();

console.log(stats);
console.log(half(stats));