// document.getElementById("count-el").innerText = 5;

let count = 0;
let counterElement = document.getElementById("count-el");

function increment() {
    count++;
    counterElement.innerText = count;
};

// The DOM
/**
 * Document Object Model
 * Its an abstract name for just how javascript is modifying a website
 * Document - html document
 * Object - means we took html document and made a javascript document out of it
 * Model - is the representation of html elements in javascript. e.g counterElement (<h2 id="count-el">0</h2>) becomes (let counterElement = document.getElementById("count-el");))
 */

let savedCounts = "Previous saves: ";
let savedElement = document.getElementById("previous-el");

function save() {
    savedCounts += count + ' - ';
    savedElement.textContent = savedCounts;
    count = 0;
    counterElement.textContent = 0;
}

/**
 * numbers convert to string by default
 */

let points = 4;
var points2 = "10";

console.log(points + points2);

let welcomeElement = document.getElementById("welcome-el");
let myName = "me";
let age = 12;

welcomeElement.innerText = `Hi, my name is ${myName} and I am ${age} years old `;
welcomeElement.innerText += "💪";