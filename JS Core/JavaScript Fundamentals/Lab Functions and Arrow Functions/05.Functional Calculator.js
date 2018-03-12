<<<<<<< HEAD
function calculate(a, b, op) {
    let calc = function (a, b, op) {
        return op(a, b)
    };
    let add = function (a, b) {
        return a + b
    };
    let subtract = function (a, b) {
        return a - b
    };
    let multiply = function (a, b) {
        return a * b
    };
    let divide = function (a, b) {
        return a / b
    };
    switch (op) {
        case '+':
            return calc(a, b, add);
        case '-':
            return calc(a, b, subtract);
        case '*':
            return calc(a, b, multiply);
        case '/':
            return calc(a, b, divide);
    }
=======
function calculate(a, b, op) {
    let calc = function (a, b, op) {
        return op(a, b)
    };
    let add = function (a, b) {
        return a + b
    };
    let subtract = function (a, b) {
        return a - b
    };
    let multiply = function (a, b) {
        return a * b
    };
    let divide = function (a, b) {
        return a / b
    };
    switch (op) {
        case '+':
            return calc(a, b, add);
        case '-':
            return calc(a, b, subtract);
        case '*':
            return calc(a, b, multiply);
        case '/':
            return calc(a, b, divide);
    }
>>>>>>> 3fabfcbfa7291745ab3525c159c85db72d9eb6ef
}