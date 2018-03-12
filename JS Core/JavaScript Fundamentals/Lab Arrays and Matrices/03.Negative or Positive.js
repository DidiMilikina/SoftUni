function negativeOrPositive(arr){
    let result = [];

    for (num of arr) {
        if(num < 0){
            result.unshift(num);
        }
        else{
            result.push(num);
        }
    }

    console.log(result.join('\n'));
}