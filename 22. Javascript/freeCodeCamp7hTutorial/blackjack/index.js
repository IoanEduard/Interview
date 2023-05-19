let sum = 0;
let hasBlackJack = false;
let isAlive = false;
let message = "";
let cardsArr = [];

let player = {
    playerName: "Eduard",
    bank: 123
}

let messageEl = document.getElementById("message-el");
let sumEl = document.querySelector("#sum-el");
let cardsEl = document.getElementById("cards-el");
let playerEl = document.getElementById("player-el");

playerEl.textContent = player.playerName + ": $" + player.bank;

function startGame() {
    isAlive = true;
    let firstCard = randomCard();
    let secondCard = randomCard();
    cardsArr = [firstCard, secondCard];
    sum = firstCard + secondCard;
    renderGame();
}

function renderGame() {
    cardsEl.textContent = "Cards: ";
    for (let i = 0; i < cardsArr.length; i++) {
        cardsEl.textContent += cardsArr[i] + " ";
    }

    sumEl.textContent = "Sum: " + sum;
    if (sum < 21) {
        message = "Draw?";
    } else if (sum === 21) {
        message = "BlackJack";
        hasBlackJack = true;
    } else {
        message = "loser";
        isAlive = false;
    }

    messageEl.textContent = message;
}

function dealCard() {
    if (isAlive && !hasBlackJack) {
        let card = randomCard();
        sum += card;
        cardsArr.push(card);
        renderGame();
    }
}

function randomCard() {
    var random = Math.floor(Math.random() * 13) + 1;
    if (random === 1) {
        random = 11;
    } else if (random == 11 || random === 12 || random === 13) {
        random = 13;
    }
    return random;
}