<<<<<<< HEAD
function templateFormat(input) {
    let dictionary = input;
    let repeats = input.length;

    let string = '<?xml version="1.0" encoding="UTF-8"?>\n<quiz>\n';

    for (i = 0; i < repeats; i += 2) {
        string += '  <question>\n    ' + dictionary[i] + '\n  </question>\n  <answer>\n    ' + dictionary[i + 1] + '\n  </answer>\n'
    }
    console.log(string + '</quiz>');
}

/* templateFormat(["Who was the forty-second president of the U.S.A.?",
    "William Jefferson Clinton",
    "Who was the forty-second president of the U.S.A.?",
    "William Jefferson Clinton"
=======
function templateFormat(input) {
    let dictionary = input;
    let repeats = input.length;

    let string = '<?xml version="1.0" encoding="UTF-8"?>\n<quiz>\n';

    for (i = 0; i < repeats; i += 2) {
        string += '  <question>\n    ' + dictionary[i] + '\n  </question>\n  <answer>\n    ' + dictionary[i + 1] + '\n  </answer>\n'
    }
    console.log(string + '</quiz>');
}

/* templateFormat(["Who was the forty-second president of the U.S.A.?",
    "William Jefferson Clinton",
    "Who was the forty-second president of the U.S.A.?",
    "William Jefferson Clinton"
>>>>>>> 081ab26d4119c9c4893599e2ed698c0a482c6fae
]); */