function rounding(arr){
    let [num, precision] = arr;
    let denominator = Math.pow(10, precision);
    console.log(Math.round(num * denominator) / denominator);
}

//rounding([10.5, 3]);                