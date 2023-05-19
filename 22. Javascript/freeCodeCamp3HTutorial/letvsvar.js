/**
 * we can declare var twice, we cannot declare let twice
 */

"use strict"; // enables strict mode, declared at the top of the file of function to avoid unsafe actions

// var is declared globally if is declared or outside a function and locally if is declared inside a function
// let is limited to the block statement or expression that it was declared in

function checkScope() {
    "use strict";
    // let i = "function scope";
    if (true) {
        // i = "block scope";
        // let i = "block scope";
        var i = "block scope";
        console.log("block scope is: " + i);
    }
    console.log("function scope is " + i);
    return i;
}

checkScope();
/**
 * if we declare with var inside the if, we still have access to i outside the block
 * if we declare with let inside the if, we get an error when we try to console.log the i
 */

/**
 * const throws errors if we reassign the value to a variable
 * convention is to use capital letters
 * its recomended to use only let and var 
 * we can update const arrays with bracket notations, we cannot reassign the whole array.
 */