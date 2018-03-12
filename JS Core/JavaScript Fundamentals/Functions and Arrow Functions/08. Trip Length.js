function tripLength(input) {
    let [x1, y1, x2, y2, x3, y3] = input.map(Number);

    let AB = Math.sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
    let BC = Math.sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3));
    let AC = Math.sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));

    if (AB + BC <= BC + AC) {
        console.log('1->2->3: ' + Number(AB + BC));
    }
    else if(AB + AC < BC + AC){
        console.log('2->1->3: ' + Number(AB + AC));
    }
    else{
        console.log('1->3->2: ' + Number(BC + AC));
    }
}
/* tripLength([-1, -2, 3.5, 0, 0, 2]); */