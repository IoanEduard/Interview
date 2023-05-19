const person = {
    "name": "Gigel",
    "age": 12,
    "country": "Romania"
};

function logData() {
    return `${person.name} is ${person.age} years old and lives in ${person.country}`;
}

console.log(logData());

let largeCountries = ["Tuvalu", "India", "USA", "Indonesia", "Monaco"];
largeCountries.shift();
largeCountries.unshift("China");

largeCountries.pop();
largeCountries.push("Pakistan");

console.log(largeCountries);

let hands = ["rock", "paper", "scissor"];

let i = 0;
let max = 2;
let min = 1;
while (i < 10) {
    let rand = Math.floor(Math.random() * (max - min + 1) + min);
    console.log(hands[rand]);
    i++;
}

let fruits = ["apple", "orange", "orange", "apple", "orange", "apple"];
let appleShelf = document.getElementById("apple-shelf");
let orangeShelf = document.getElementById("orange-shelf");

for (let i = 0; i < fruits.length; i++) {
    if (fruits[i] === "orange") {
        orangeShelf.textContent += fruits[i];
        orangeShelf.textContent += " ";
    }

    if (fruits[i] === "apple") {
        appleShelf.textContent += fruits[i];
        appleShelf.textContent += " ";
    }
}