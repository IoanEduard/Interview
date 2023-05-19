function caseInSwitch(val) {
    var answer = "";

    switch (val) {
        case 'alpha':
            answer = 1;
            break;
        case 'beta':
        case 'theta':
            answer = 2;
        case 'zeta':
            answer = 3;
            break;
        default:
            answer = -1;
            break;
    }

    return answer;
}

console.log(caseInSwitch("alpha"));