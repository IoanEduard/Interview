import fs from 'fs';

export function writeArrayToFile(array, filePath) {
    var stringfied = JSON.stringify(array);

    fs.writeFile(filePath, stringfied, (err) => {
        if (err) {
            console.error('Error writing file:', err);
            return;
        }
        console.log('File written successfully!');
    });
}