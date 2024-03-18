'use strict';
$(document).ready(function () {
    $('#calculate').click(function () {
        var firstNumber = parseInt($('#firstNumber').val());
        var secondNumber = parseInt($('#secondNumber').val());
        var operator = $('#operator').val();
        var result;

        switch (operator) {
            case '+':
                result = firstNumber + secondNumber;
                break;
            case '-':
                result = firstNumber - secondNumber;
                break;
            case '*':
                result = firstNumber * secondNumber;
                break;
            case '/':
                result = firstNumber / secondNumber;
                break;
            default:
                result = 'Invalid operator';
        }

        $('#result').text('Result: ' + result);
    });
});
