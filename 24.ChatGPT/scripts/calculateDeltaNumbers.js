export function calculateDeltaNumbers(inputArray) {
    const resultArray = inputArray.reduce((acc, curr, index, arr) => {
        if (index === 0) {
            acc.push(curr);
        } else {
            const diff = curr - arr[index - 1];
            acc.push(diff);
        }
        return acc;
    }, []);

    return resultArray;
}