class Book {
    constructor(author) {
        this._author = author;
    }

    get writer() {
        return this._author;
    }

    set writer(updatedAuthor) {
        this._author = updatedAuthor;
    }
}

function makeClass() {
    class Thermostat {
        constructor(temp) {
            this._temp = 5 / 9 * (temp - 32);
        }

        get temperature() {
            return this._temp;
        }
        set temperature(updatedTemperature) {
            this._temp = updatedTemperature;
        }
    }

    return Thermostat;
}

const Thermostat = makeClass();
const thermos = new Thermostat(67);
let temp = thermos.temperature;
thermos.temperature = 25;
temp = thermos.temperature;
console.log(temp);