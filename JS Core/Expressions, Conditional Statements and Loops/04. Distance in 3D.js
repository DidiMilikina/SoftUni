function distance(coordinates){
    let x1 = Number(coordinates[0]);
    let y1 = Number(coordinates[1]);
    let z1 = Number(coordinates[2]);
    let x2 = Number(coordinates[3]);
    let y2 = Number(coordinates[4]);
    let z2 = Number(coordinates[5]);

    let distance = Math.sqrt(Math.pow(x1-x2,2) + Math.pow(y1-y2,2) + Math.pow(z1-z2,2));
    console.log(distance);
}