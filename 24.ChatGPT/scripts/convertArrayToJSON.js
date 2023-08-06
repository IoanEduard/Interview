export function convertArrayToJSON(inputArray) {
    const jsonArray = inputArray.map((str) =>
        str.split(' ')
        .map(Number)
        .sort((a, b) => a - b));

    return jsonArray;
}