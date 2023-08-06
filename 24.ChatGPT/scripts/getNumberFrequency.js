export function getNumberFrequency(arr) {
    const frequencyMap = {};

    // Iterate over each array
    for (let i = 0; i < arr.length; i++) {
        const subArray = arr[i];

        // Iterate over each number in the sub-array
        for (let j = 0; j < subArray.length; j++) {
            const number = subArray[j];

            // If number already exists in the frequency map, increment its count
            if (frequencyMap.hasOwnProperty(number)) {
                frequencyMap[number] += 1;
            } else {
                // Otherwise, initialize the count to 1
                frequencyMap[number] = 1;
            }
        }
    }

    // Return the frequency map
    return frequencyMap;
}