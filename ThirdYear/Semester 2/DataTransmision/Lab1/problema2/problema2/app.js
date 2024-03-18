'use strict';

document.getElementById("n").addEventListener('input', inputSum);

function inputSum() {
    var inputNumber = parseInt(document.getElementById("n").value);
    console.log(inputNumber);
    sum(inputNumber);
}

function sum(n) {
    if (isNaN(n)) return "not a number";
    if (typeof n === 'undefined') return "n is undefined";
    var total = 0;
    for (var i = 1; i <= n; i++) {
        total += i;
    }
    console.log(total);
    return total;
}
