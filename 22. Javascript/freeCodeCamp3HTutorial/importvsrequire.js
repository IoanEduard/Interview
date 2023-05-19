export const variableToUpper = str => str.toUpperCase();

// In another file we can do:
import { variableToUpper } from "./thatFile.js"

const cap = variableToUpper("hello");
console.log(cap);

import * as capitalizeStrings from './thapath/thatfile.js';

export default x; // export fallback, exporting only this variable