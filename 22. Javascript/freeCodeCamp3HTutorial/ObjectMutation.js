// Prevent Object Mutation

function freezeObj() {
    "use strict";

    const MATH_CONSTANTS = {
        "PI": 3.14
    };

    // Object.freeze(MATH_CONSTANTS);

    try {
        MATH_CONSTANTS.PI = 99
    } catch (exception) {
        console.log(exception)
    }

    return MATH_CONSTANTS.PI;
}

const PI = freezeObj();

console.log(PI);