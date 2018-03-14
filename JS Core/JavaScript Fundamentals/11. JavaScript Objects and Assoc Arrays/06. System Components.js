function systemComponents(input) {
    let systems = new Map();

    for (let line of input) {
        let tokens = line.split(/\s*\|\s*/);
        let currentSystem = tokens[0];
        let currentComponent = tokens[1];
        let currentSubcomponent = tokens[2];

        if (!systems.get(currentSystem)) {
            systems.set(currentSystem, new Map());
        }
        if (!systems.get(currentSystem).get(currentComponent)) {
            systems.get(currentSystem).set(currentComponent, []);
        }
        systems.get(currentSystem).get(currentComponent).push(currentSubcomponent);
    }

    let sortedSystems = Array.from(systems.keys()).sort((s1, s2) => sortSystems(s1, s2));

    for (let currentSystem of sortedSystems) {
        console.log(currentSystem);
        let componentsSorted = Array.from(systems.get(currentSystem).keys())
            .sort((c1, c2) => sortComponents(currentSystem, c1, c2));

        for (let currentComponent of componentsSorted) {
            console.log(`|||${currentComponent}`);
            systems.get(currentSystem).get(currentComponent).forEach(sc => console.log(`||||||${sc}`));
        }
    }

    function sortSystems(s1, s2) {
        if (systems.get(s1).size != systems.get(s2).size) {
            return systems.get(s2).size - systems.get(s1).size;
        } else {
            return s1.toLowerCase().localeCompare(s2.toLowerCase());
        }
    }

    function sortComponents(currentSystem, c1, c2) {
        return systems.get(currentSystem).get(c2).length - systems.get(currentSystem).get(c1).length;
    }
}

/* systemComponents([
    'SULS | Main Site | Home Page',
    'SULS | Main Site | Login Page',
    'SULS | Main Site | Register Page',
    'SULS | Judge Site | Login Page',
    'SULS | Judge Site | Submittion Page',
    'Lambda | CoreA | A23',
    'SULS | Digital Site | Login Page',
    'Lambda | CoreB | B24',
    'Lambda | CoreA | A24',
    'Lambda | CoreA | A25',
    'Lambda | CoreC | C4',
    'Indice | Session | Default Storage',
    'Indice | Session | Default Security'
]); */