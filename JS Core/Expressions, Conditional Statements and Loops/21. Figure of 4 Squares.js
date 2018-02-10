function figure(num){
    let length = num % 2 !== 0 ? num : num - 1;
    let count = (2 * num - 4) / 2;
    let middle = Math.ceil(length / 2);

    for (let i = 1; i <= length; i++) {
        if (i === 1 || i === middle || i === length) {
            console.log(`+${'-'.repeat(count)}+${'-'.repeat(count)}+`);
        }else{
            console.log(`|${' '.repeat(count)}|${' '.repeat(count)}|`);
        }
    }

}

//figure(5);