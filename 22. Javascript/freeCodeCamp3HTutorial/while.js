var myarray = [];
var i = 0;
while (i < 5) {
    myarray.push(i);
    i++;
}

console.log(myarray);

// for loop is the same as any other language

/**
 * do while runs at least once then runs the condition
 * while checks first the condition
 */

const contacts = [{
        firstName: "Akira",
        lastName: "Laine",
        number: "0543236543",
        likes: ["Pizza", "Coding", "Brownie Points"],
    },
    {
        firstName: "Harry",
        lastName: "Potter",
        number: "0994372684",
        likes: ["Hogwarts", "Magic", "Hagrid"],
    },
    {
        firstName: "Sherlock",
        lastName: "Holmes",
        number: "0487345643",
        likes: ["Intriguing Cases", "Violin"],
    },
    {
        firstName: "Kristian",
        lastName: "Vos",
        number: "unknown",
        likes: ["JavaScript", "Gaming", "Foxes"],
    },
];

function lookUpProfile(name, prop) {
    var resultName = "No such name was found";
    var property = "No such property was found";

    for (var i = 0; i < contacts.length; i++) {
        if (contacts[i].firstName === name) {
            resultName = contacts[i].firstName;
            if (Object.hasOwn(contacts[i], prop)) {
                property = contacts[i][prop];
                return {
                    name: resultName,
                    property: property
                }
            }
        }
    }

    return name + " " + property;
}
console.log(lookUpProfile("Akira", "likes"));