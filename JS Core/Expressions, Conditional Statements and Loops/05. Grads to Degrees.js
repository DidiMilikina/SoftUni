function gradsToDegrees(grads){
    grads %= 400;
    grads = grads < 0 ? 400 + grads : grads;
    grads *= 0.9; // 360 / 400

    return grads;
}

//console.log(gradsToDegrees(850));