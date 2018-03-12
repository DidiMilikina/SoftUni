function expressionSplit(expression) {
    let elements = expression
        .split(/[\s.();,]+/);

    console.log(elements.join("\n"));
}

/* expressionSplit(['let sum = 4 * 4,b = "wow";']); */