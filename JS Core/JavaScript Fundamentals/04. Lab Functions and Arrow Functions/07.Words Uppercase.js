<<<<<<< HEAD
function wordsUppercase(str) {
    let strUpper = str.toUpperCase();
    let words = extractWords();
    words = words.filter(w => w != '');
    return words.join(', ');

    function extractWords() {
        return strUpper.split(/\W+/);
    }
=======
function wordsUppercase(str) {
    let strUpper = str.toUpperCase();
    let words = extractWords();
    words = words.filter(w => w != '');
    return words.join(', ');

    function extractWords() {
        return strUpper.split(/\W+/);
    }
>>>>>>> 3fabfcbfa7291745ab3525c159c85db72d9eb6ef
}