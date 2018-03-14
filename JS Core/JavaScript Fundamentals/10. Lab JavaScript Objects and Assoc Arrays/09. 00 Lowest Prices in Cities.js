function lowestPricesInCities(input) {
    let store = new Map();

    for (let current of input) {
        let tokens = current.split(" | ");
        let currentTown = tokens[0];
        let currentProduct = tokens[1];
        let currentPrice = Number(tokens[2]);

        if (!store.has(currentProduct)) {
            store.set(currentProduct, new Map());
        }
        store.get(currentProduct).set(currentTown, currentPrice);
    }

    for (let [currentProduct, insideMap] of store) {
        let lowestPrice = Number.MAX_VALUE;
        let townLowestPrice = '';

        for (let [currentTown, currentPrice] of insideMap) {
            if (currentPrice < lowestPrice) {
                lowestPrice = currentPrice;
                townLowestPrice = currentTown;
            }
        }

        console.log(`${currentProduct} -> ${lowestPrice} (${townLowestPrice})`);
    }
}

/* lowestPricesInCities([
    'Sofia City | Audi | 100000',
    'Sofia City | BMW | 100000',
    'Sofia City | Mitsubishi | 10000',
    'Sofia City | Mercedes | 10000',
    'Sofia City | NoOffenseToCarLovers | 0',
    'Mexico City | Audi | 1000',
    'Mexico City | BMW | 99999',
    'New York City | Mitsubishi | 10000',
    'New York City | Mitsubishi | 1000',
    'Mexico City | Audi | 100000',
    'Washington City | Mercedes | 1000'
]); */