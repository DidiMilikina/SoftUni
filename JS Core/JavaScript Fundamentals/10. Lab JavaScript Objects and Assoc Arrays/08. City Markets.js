function cityMarkets(input) {
    let towns = new Map();
    
    for (let sale of input) {
        let [town, product, quantityPrice] = sale.split(/\s*->\s*/);
        let [quantity, price] = quantityPrice.split(/\s*:\s*/);
        let income = Number(quantity) * Number(price);

        if (!towns.has(town)) {
            towns.set(town, new Map());
            towns.get(town).set(product, income);
        } else {
            if (!towns.get(town).has(product)) {
                towns.get(town).set(product, income);
            } else {
                towns.get(town).set(product, town.get(product) + income);
            }
        }
    }

    let print = '';
    for (let [index, value] of towns) {
        print += (`Town - ${index}\n`);
        for (let [product, price] of towns.get(index)) {
            print += (`$$$${product} : ${price}\n`);
        }
    }
    return print;
}

/* console.log(cityMarkets([
    'Sofia -> Laptops HP -> 200 : 2000',
    'Sofia -> Raspberry -> 200000 : 1500',
    'Sofia -> Audi Q7 -> 200 : 100000',
    'Montana -> Portokals -> 200000 : 1',
    'Montana -> Qgodas -> 20000 : 0.2',
    'Montana -> Chereshas -> 1000 : 0.3'
])); */