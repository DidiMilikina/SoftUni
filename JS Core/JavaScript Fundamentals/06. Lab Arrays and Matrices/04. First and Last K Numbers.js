function a(input) {

    let k = Number(input[0]);

    let firstRow = input.slice(1, k + 1);
    let lastRow = input.slice(input.length - k, input.length);
    console.log(firstRow);
    console.log(lastRow);

}