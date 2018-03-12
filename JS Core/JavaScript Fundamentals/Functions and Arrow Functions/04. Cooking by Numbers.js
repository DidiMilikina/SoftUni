function cookingByNums(arr){
    let [start, op1, op2, op3, op4, op5] = 
        [Number(arr[0]), arr[1], arr[2], arr[3], arr[4], arr[5]];

    let chop = (num) => num / 2;
    let dice = (num) => Math.sqrt(num);
    let spice = (num) => ++num;
    let bake = (num) => num * 3;
    let fillet = (num) => num -= num * 0.2;

    for (let operation of [op1, op2, op3, op4, op5]) {
        switch (operation) {
            case 'chop':
                start = chop(start);
                break;
            case 'dice':
                start = dice(start);
                break;
            case 'spice':
                start = spice(start);
                break;
            case 'bake':
                start = bake(start);
                break;
            case 'fillet':
                start = fillet(start);
                break;
        }
        console.log(start);
    }
}

//cookingByNums(['32', 'chop', 'chop', 'chop', 'chop', 'chop']);