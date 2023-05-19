function fn(a, b) {
    console.log(a - b);
}

// fn(5, 10);

// Global Scope and functions
/**
 * global scope is seen everywhere in the javascript code 
 */

var global = 10;

function fn1() {
    var noGlobalVariableDeclared = 5;
}

function fn2() {
    var output = "";
    if (typeof global !== "undefined") {
        output += "global: " + global;
    }

    if (typeof noGlobalVariableDeclared !== "undefined") {
        output += "noGlobalVariableDeclared: " + noGlobalVariableDeclared;
    }
    console.log(output);
}

// fn1();
// fn2();

// localScope

function localScopeFn() {
    var variable = 5;
    console.log(variable);
}

// localScopeFn();
// console.log(variable);

// global vs local variables
var x = 1;

function fnX() {
    var x = 2;
    return x;
}

console.log(fnX());
console.log(x);

/**
 * functions can return a value
 * if we don't specify the return then it will return undefined
 */

// we can assign a variable to a fn