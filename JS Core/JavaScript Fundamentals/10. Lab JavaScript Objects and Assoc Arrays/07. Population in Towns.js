function populationInTowns(input) {
    let store = new Map();

    for (const data of input) {
        let [town, population] = data.split(/\s*<->\s*/);
        population = Number(population);
        if (store.has(town)) {
            store.set(town, store.get(town) + population);
        } else {
            store.set(town, population);
        }
    }
    for (const [town, sum] of store) {
        console.log(town + ' : ' + sum);
    }
}

/* populationInTowns([
    'Sofia <-> 1200000',
    'Montana <-> 20000',
    'New York <-> 10000000',
    'Washington <-> 2345000',
    'Las Vegas <-> 1000000'
]); */