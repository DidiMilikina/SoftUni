function printEveryNthElement(input) {
    let step = Number(input[input.length - 1]);

    for (let i = 0; i < input.length - 1; i += step) {
        console.log(input[i]);
    }
}

/* printEveryNthElement(['5', '20', '31', '4', '20', '2']); */