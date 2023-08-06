// http://noroc-chior.ro/Loto/6-din-49/arhiva-rezultate.php?Y=2021

function extractNumbersFromRows() {
    var rows = document.querySelectorAll('tr');
    var numberArrays = [];

    for (var i = 0; i < rows.length; i++) {
        var tds = rows[i].querySelectorAll('.odd_rounded, .even_rounded');
        var numbers = [];

        for (var j = 0; j < tds.length; j++) {
            var text = tds[j].textContent.trim();
            var number = parseInt(text);

            if (!isNaN(number)) {
                numbers.push(number);
            }
        }

        if (numbers.length > 0) {
            var numberString = numbers.join(' ');
            numberArrays.push(numberString);
        }
    }

    return numberArrays;
}

// Usage
var extractedNumbers = extractNumbersFromRows();
console.log(extractedNumbers);