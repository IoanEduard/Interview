var spaceShuttle = function(targetPlanet) {
    this.targetPlanet = targetPlanet;
}

// we use new for creating object
var zeus = new spaceShuttle('Jupiter');

console.log(zeus.targetPlanet);

class spaceShuttle {
    constructor(targetPlanet) {
        this.targetPlanet = targetPlanet;
    }
}

function makeClass() {
    class Vegetable {
        constructor(name) {
            this.name = name;
        }
    }

    return Vegetable;

}
const Vegetable = makeClass();
const carrot = new Vegetable('carrot');
console.log(carrot.name);