function validityChecker(arr) {
    let [x1, y1, x2, y2] = arr.map(Number);

    function checkValidity(x1, y1, x2, y2) {
        let deltaX = x2 - x1;
        let deltaY = y2 - y1;
        let distance = Math.sqrt(deltaX * deltaX + deltaY * deltaY);
        if (distance % 1 == 0) {
            console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is valid`);
        } else {
            console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is invalid`);
        }
    }

    checkValidity(x1, y1, 0, 0);
    checkValidity(x2, y2, 0, 0);
    checkValidity(x1, y1, x2, y2);
}

/* validityChecker([2, 1, 1, 1]); */