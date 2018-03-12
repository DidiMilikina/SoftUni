function modify(num){
    let numAsStr = num.toString();
    let sum = sumDigits(numAsStr);

    while (sum / numAsStr.lenght <= 5) {
        numAsStr += 5;
        sum = sumDigits(numAsStr);
    }

    console.log(numAsStr);
    function sumDigits(numAsStr){
        let sum = 0;
        for (let digit of numAsStr) {
            sum += Number(digit);
        }
        
        return sum;
    }
}

//modify(5815);