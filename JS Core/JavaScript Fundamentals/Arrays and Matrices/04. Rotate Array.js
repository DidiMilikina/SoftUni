<<<<<<< HEAD
function rotateArray(input) {
    let rotations = Number(input.pop());
    rotations %= input.length;

    for (let i = 0; i < rotations; i++) {
        input.unshift(input.pop());
    }

    console.log(input.join(' '));
}

=======
function rotateArray(input) {
    let rotations = Number(input.pop());
    rotations %= input.length;

    for (let i = 0; i < rotations; i++) {
        input.unshift(input.pop());
    }

    console.log(input.join(' '));
}

>>>>>>> 081ab26d4119c9c4893599e2ed698c0a482c6fae
/* rotateArray(['Banana', 'Orange', 'Coconut', 'Apple', '15']); */