function cappyJuice(input) {
    let quantity = {};
    let bottles = {};

    for (const line of input) {
        let tokens = line.split(' => ');
        let currentFruit = tokens[0];
        let currentQuantity = Number(tokens[1]);

        if (!quantity.hasOwnProperty(currentFruit)) {
            quantity[currentFruit] = 0;
        }

        quantity[currentFruit] += currentQuantity;

        if (quantity[currentFruit] >= 1000) {
            bottles[currentFruit] = parseInt(quantity[currentFruit] / 1000);
        }
    }

    for (const key of Object.keys(bottles)) {
        console.log(`${key} => ${bottles[key]}`);
    }
}

/* cappyJuice([
    'Orange => 2000',
    'Peach => 1432',
    'Banana => 450',
    'Peach => 600',
    'Strawberry => 549'
]); */