// avoiding redundant code
const createPerson = (name, age, gender) => ({ name, age, gender });
console.log(createPerson("Zodiac Hasbro", 56, "male"));

// we can avoid using keybord function

const bycle = {
    gear: 2,
    setGear(newGear) {
        "use strict";
        this.gear = newGear
    }
};

bycle.setGear(3);
console.log(bycle.gear);