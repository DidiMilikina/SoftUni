<<<<<<< HEAD
function palindrome(str) {
    for (let i = 0; i < str.length / 2; i++)
        if (str[i] != str[str.length - i - 1])
            return false;
    return true;
}
=======
function palindrome(str) {
    for (let i = 0; i < str.length / 2; i++)
        if (str[i] != str[str.length - i - 1])
            return false;
    return true;
}
>>>>>>> 3fabfcbfa7291745ab3525c159c85db72d9eb6ef
//palindrome("abccba");