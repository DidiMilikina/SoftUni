function roadRadar(input) {
    let speed = Number(input[0]);
    let place = input[1].toLowerCase();

    isSpeedLimit(speed, place);

    function isSpeedLimit(speed, place) {
        let speedLimits = {
            'motorway': 130,
            'interstate': 90,
            'city': 50,
            'residential': 20
        };

        if (speed <= speedLimits[place]) {

        } else {
            if (speed - speedLimits[place] <= 20) {
                console.log('speeding');
            } else if (speed - speedLimits[place] <= 40) {
                console.log('excessive speeding');
            } else {
                console.log('reckless driving');
            }
        }
    }
}

//roadRadar([40, 'city']);