function autoEngineeringCompany(input) {
    let cars = new Map();

    for (const line of input) {
        let tokens = line.split(' | ');
        let currentCarBrand = tokens[0];
        let currentCarModel = tokens[1];
        let producedCars = Number(tokens[2]);

        if (!cars.get(currentCarBrand)) {
            cars.set(currentCarBrand, new Map());
        }
        if (!cars.get(currentCarBrand).get(currentCarModel)) {
            cars.get(currentCarBrand).set(currentCarModel, 0);
        }

        cars.get(currentCarBrand).set(currentCarModel, cars.get(currentCarBrand).get(currentCarModel) + producedCars);
    }

    for (const [currentCarBrand, modelCount] of cars) {
        console.log(currentCarBrand);
        for (const [currentCarModel, producedCars] of modelCount) {
            console.log(`###${currentCarModel} -> ${producedCars}`);
        }
    }
}

/* console.log(autoEngineeringCompany([
    'Audi | Q7 | 1000',
    'Audi | Q6 | 100',
    'BMW | X5 | 1000',
    'BMW | X6 | 100',
    'Citroen | C4 | 123',
    'Volga | GAZ-24 | 1000000',
    'Lada | Niva | 1000000',
    'Lada | Jigula | 1000000',
    'Citroen | C4 | 22',
    'Citroen | C5 | 10'
])); */