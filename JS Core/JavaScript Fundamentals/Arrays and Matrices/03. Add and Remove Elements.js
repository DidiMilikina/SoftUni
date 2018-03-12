<<<<<<< HEAD
function addAndRemoveElements(input) {
    let result = [];
    let number = 1;

    for (let command of input) {
        if (command == 'add') {
            result.push(number);
        } else {
            result.pop();
        }
        number++;
    }

    if (result.length == 0) {
        console.log('Empty');
    } else {
        result.forEach(element => console.log(element));
    }
}

=======
function addAndRemoveElements(input) {
    let result = [];
    let number = 1;

    for (let command of input) {
        if (command == 'add') {
            result.push(number);
        } else {
            result.pop();
        }
        number++;
    }

    if (result.length == 0) {
        console.log('Empty');
    } else {
        result.forEach(element => console.log(element));
    }
}

>>>>>>> 081ab26d4119c9c4893599e2ed698c0a482c6fae
/* addAndRemoveElements(['add', 'add', 'remove', 'add', 'add']); */