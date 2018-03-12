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
]); */