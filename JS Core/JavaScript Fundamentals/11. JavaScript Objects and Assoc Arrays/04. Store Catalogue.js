function storeCatalogue(input) {
    let map = new Map();

    for(let line of input){
        let tokens = line.split(" : ");
        let currentProduct = tokens[0];
        let currentPrice = tokens[1];
        map.set(currentProduct, currentPrice);
    }

    let firstLetter = new Set();
    Array.from(map.keys()).forEach(l => firstLetter.add(l[0]));


    for(let letter of Array.from(firstLetter.keys()).sort()) {
        console.log(letter);

        for(let currentProduct of Array.from(map.keys()).sort()){
            if(currentProduct.startsWith(letter)) {
                console.log(`  ${currentProduct}: ${map.get(currentProduct)}`);
            }
        }
    }
}

/* console.log(storeCatalogue([
    'Appricot : 20.4',
    'Fridge : 1500',
    'TV : 1499',
    'Deodorant : 10',
    'Boiler : 300',
    'Apple : 1.25',
    'Anti-Bug Spray : 15',
    'T-Shirt : 10'
])); */