function extractWords(inputSentences) {
    let uniqueWords = new Set();

    for (let sentence of inputSentences) {
        let words = sentence.toLowerCase().match(/\b[a-zA-Z0-9_]+\b/g);

        for (let word of words) {
            uniqueWords.add(word);
        }
    }
    console.log([...uniqueWords.values()].join(", "));
}

/* extractWords(['JS devs use Node.js for server-side JS.',
    'JS devs use JS.',
    '-- JS for devs --'
]); */