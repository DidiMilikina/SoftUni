function sumOfTowns(input) {
    let sum = {};

    for (let i = 0; i < input.length; i += 2) {
        let town = input[i];
        let income = Number(input[i + 1]);

        if (sum[town] == undefined) {
            sum[town] = income;
        } else {
            sum[town] += income;
        }
    }
    return JSON.stringify(sum);
}

/* console.log(sumOfTowns(['Sofia', '20', 'Varna', '3', 'Sofia', '5', 'Varna', '4'])); */