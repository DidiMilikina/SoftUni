function binaryToDecimal(input){
  let finalResult = 0;
  
  for (let i = 0; i < input.length; i++) {
    finalResult += Number(input[7 - i]) * Math.pow(2, i);
  }
  console.log(finalResult);
}