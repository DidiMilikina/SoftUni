function townsToJson(input) {
    let townsArr = [];

    for (const town of input.slice(1)) {
        let [empty, townName, latitude, longitude] = town.split(/\s*\|\s*/);

        let townObj = {
            Town: townName,
            Latitude: Number(latitude),
            Longitude: Number(longitude)
        };
        townsArr.push(townObj);
    }
    return JSON.stringify(townsArr);
}

/* console.log(townsToJson(['| Town | Latitude | Longitude |',
    '| Sofia | 42.696552 | 23.32601 |',
    '| Beijing | 39.913818 | 116.363625 |'
])); */