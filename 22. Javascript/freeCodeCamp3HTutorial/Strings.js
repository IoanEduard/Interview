var doubleQuoted = "I am a \"double quouted\" string"; // escape

var singleQuote = '<a href = "https://www.example.com/"';
var backThinks = `variable`;

/**
 * Code Output
 * \' single quote
 * \" double quote
 * \\ backlash
 * \n newline
 * \r carriage return 
 * \t tab
 * \b backspace
 * \f form feed
 */

var myStr = "First line\n\t\\SecondLine\nThirdLine";

var sr = "First " + "Second ";
sr += "Third";

console.log(sr);

var str1 = "me";
var str2 = "you";

console.log(str2 + "build a string with " + str1);

var len = str2.length;

// bracket notation to find the character at a specific index
var character = str2[0];

// strings are immutable
var sr = "icream is bad";
sr[0] = ""; //error
sr = "cream is bad" // we assign a new string

sr[sr.length - 1];

function makeString(word1, word2, word3, word4) {
    let result = "";
    result = word1 + " " + word2 + " " + word3 + " " + word4;

    return result;
}

console.log(makeString("a", "b", "c", 1));