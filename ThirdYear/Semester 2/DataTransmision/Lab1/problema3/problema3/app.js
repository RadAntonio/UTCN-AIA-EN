'use strict';
function fibonacciRecursive(n) {
    if (n <= 1) {
        return n;
    } else {
        return fibonacciRecursive(n - 1) + fibonacciRecursive(n - 2);
    }
}

// Test the function
function print() {

    var n = document.getElementById("limit").value;
    if (n === '') {
        console.log("not allowed");
    } else {
        console.log("Fibonacci sequence up to", n, ":");
        console.log("1");
        for (let i = 1; i <= n; i++) {
            console.log(fibonacciRecursive(i));
        }
    }
}
document.getElementById('show').addEventListener('click', print);