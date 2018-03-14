function countWordsWithMaps(input) {
    let text = input.join('\n').toLowerCase();

    let regex = /[^A-Za-z0-9_]+/;
    let words = text.split(regex).filter(w => w != '');
    let wordsCount = new Map();

    for (const current of words) {
        if (wordsCount.has(current)) {
            wordsCount.set(current, wordsCount.get(current) + 1);
        } else {
            wordsCount.set(current, 1);
        }
    }

    let allWords = Array.from(wordsCount.keys()).sort();
    allWords.forEach(w => console.log('\'' + w + '\' ' + '-> ' + wordsCount.get(w) + ' times'));
}

/* countWordsWithMaps((['JS and Node.js', 'JS again and again', 'Oh, JS?'])); */