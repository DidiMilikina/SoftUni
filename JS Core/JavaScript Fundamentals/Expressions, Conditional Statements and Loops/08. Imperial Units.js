function imperialUnits(input){
    let inches = input % 12;
    let foots = (input - inches) / 12;
    console.log(foots + "'" + '-' + inches + '"');
}