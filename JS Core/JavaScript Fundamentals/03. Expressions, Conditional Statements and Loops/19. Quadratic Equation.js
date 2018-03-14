function quadraticEquation(a,b,c) {
    var d = (Math.pow(b, 2) - (4 * a * c));
    var x1 = (-b + Math.sqrt(d)) / (2 * a);
    var x2 = (-b - Math.sqrt(d)) / (2 * a);

    if (d > 0) {
        x1 = (-b - Math.sqrt(d)) / (2 * a);
        x2 = (-b + Math.sqrt(d)) / (2 * a);
        if(x1 < x2){
            console.log(x1);
            console.log(x2);
        }else{
            console.log(x2);
            console.log(x1);
        }
    }else if (d == 0) {
        x1 = (-b) / (2 * a);
        console.log(x1);
    }else {
        console.log("No");
    }
}