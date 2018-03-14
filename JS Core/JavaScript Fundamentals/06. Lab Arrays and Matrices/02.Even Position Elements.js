function evenPosition(input) {
    let string = '';
    for (let i = 0; i < input.length; i++) {
        if (i % 2 == 0) {
            string += input[i] + ' ';
        }
    }
    console.log(string);
}
//evenPosition(['20', '30', '40']);