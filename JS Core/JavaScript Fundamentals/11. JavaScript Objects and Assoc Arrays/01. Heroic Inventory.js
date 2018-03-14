function heroicInventory(input) {
    let heroData = [];

    for (const line of input) {
        let tokens = line.split(' / ');

        let currentHerоName = tokens[0];
        let currentHeroLevel = Number(tokens[1]);
        let items = [];

        if (tokens.length > 2) {
            items = tokens[2].split(', ');
        }

        let hero = {
            name: currentHerоName,
            level: currentHeroLevel,
            items: items
        };

        heroData.push(hero);
    }
    console.log(JSON.stringify(heroData));
}

/* heroicInventory([
    'Isacc / 25 / Apple, GravityGun',
    'Derek / 12 / BarrelVest, DestructionSword',
    'Hes / 1 / Desolator, Sentinel, Antara'
]); */
