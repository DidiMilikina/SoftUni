<<<<<<< HEAD
function printAnArrayWithDelimiter(input) {
    let delimeter = input[input.length - 1];

    let result = "";
    for (let i = 0; i < input.length - 1; i++) {
        if (i == 0) {
            result += input[i];
        } else {
            result += delimeter + input[i];
        }
    }
    console.log(result);
}

/* printAnArrayWithDelimiter(['One',
    'Two',
    'Three',
    'Four',
    'Five',
    '-'
=======
function printAnArrayWithDelimiter(input) {
    let delimeter = input[input.length - 1];

    let result = "";
    for (let i = 0; i < input.length - 1; i++) {
        if (i == 0) {
            result += input[i];
        } else {
            result += delimeter + input[i];
        }
    }
    console.log(result);
}

/* printAnArrayWithDelimiter(['One',
    'Two',
    'Three',
    'Four',
    'Five',
    '-'
>>>>>>> 081ab26d4119c9c4893599e2ed698c0a482c6fae
]); */