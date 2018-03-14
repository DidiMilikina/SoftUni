function lowestPricesInCities(input) {
    let store = new Map();

    for (let i = 0; i < input.length; i++) {
        let tokens = input[i].split(/\s+\|\s+/g);
        let currentTown = tokens[0];
        let currentProduct = tokens[1];
        let currentPrice = tokens[2];

        if (!store.has(currentProduct)) {
            store.set(currentProduct, new Map());
        }
        store.get(currentProduct).set(currentTown, Number(currentPrice));
    }

    for (const [currentProduct, towns] of store) {
        let minPrice = Number.MAX_VALUE;
        let minPriceTown = 0;

        for (const [currentTown, currentPrice] of towns) {
            if (currentPrice < minPrice) {
                minPrice = currentPrice;
                minPriceTown = currentTown;
            }
        }
        console.log(`${currentProduct} -> ${minPrice} (${minPriceTown})`);
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