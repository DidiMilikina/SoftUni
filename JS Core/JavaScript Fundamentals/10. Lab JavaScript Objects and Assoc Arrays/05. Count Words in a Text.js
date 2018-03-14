function countWordsInAText(input) {
    let allWords = input[0].match(/\w+/g);
    let result = {};

    for (let currentWord of allWords) {
        if (result[currentWord] === undefined) {
            result[currentWord] = 1;
        } else {
            result[currentWord]++;
        }
    }
    console.log(JSON.stringify(result));
}

/* countWordsInAText(['Far too slow, you\'re far too slow.']);
countWordsInAText(['JS devs use Node.js for server-side JS.-- JS for devs']); */