/**
 * Takes an array and spreads it in its individual parts
 */

const arr1 = ["Jan", "Feb", "March", "April", "May"];
let arr2;

(function() {
    // arr2 = arr1;
    arr2 = [...arr1];
    arr2[0] = 'potato'
})();

console.log(arr2);
console.log(...arr2);