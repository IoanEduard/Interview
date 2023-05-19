var dog = {
    "name": "john",
    "legs": 3,
    "tail": true,
    "friends": ["billy", "susan"]
}

// console.log(dog.name);
// console.log(dog["name"]);

var dogName = "name";
console.log(dog[dogName]);

dog.friends.push("caren");
dog.tail = false;

console.log(dog);

dog["bark"] = "woof";
dog.teeth = 24;

console.log(dog);

delete dog.bark;

var lookup = {
    "alpha": "Adam",
    "bravo": "Boston",
    "charlie": "LA",
    "delta": "CA"
};

result = lookup["delta"];
console.log(result);

function checkProperty(checkProperty) {
    if (dog.hasOwnProperty(checkProperty))
        return dog[checkProperty];
    else
        return "Not Found"
}
console.log(checkProperty("name"));

var playlist = [{
        "artist": "bolly",
        "title": "singing piano",
        "release_year": 1772,
        "formats": [
            "cd",
            "lp"
        ],
        "gold": true
    },
    {
        "artist": "susan",
        "title": "singing piano",
        "release_year": 1772,
        "formats": [
            "cd",
            "lp"
        ],
        "gold": true
    }
];

console.log(playlist);

var nestedObjects = {
    car: {
        "wheel": true,
        "color": "white",
        "year": 2017,
        "engine": {
            "power": "12 horses",
            "exhaust": true,
            "chair": {
                "color": "blue",
                "material": "leather"
            }
        }
    },
    "house": {
        "doors": [
            "front",
            "back",
            "ceil"
        ]
    }
}

console.log(nestedObjects.house.doors[2]);

const recordCollection = {
    2548: {
        albumTitle: 'Slippery When Wet',
        artist: 'Bon Jovi',
        tracks: ['Let It Rock', 'You Give Love a Bad Name']
    },
    2468: {
        albumTitle: '1999',
        artist: 'Prince',
        tracks: ['1999', 'Little Red Corvette']
    },
    1245: {
        artist: 'Robert Palmer',
        tracks: []
    },
    5439: {
        albumTitle: 'ABBA Gold'
    }
};

function updateRecords(records, id, prop, value) {
    if (value === null)
        delete recordCollection[id][prop];
    else if (prop === "tracks") {
        recordCollection[id][prop] = recordCollection[id][prop] || [];
        recordCollection[id][prop].push(value);
    } else
        recordCollection[id][prop] = value;

    return records;
}

updateRecords(2468, "tracks", "test");
updateRecords(recordCollection, 5439, 'artist', 'ABBA');