function sortAnArrayBy2Criteria(input) {

    console.log(input.sort(compare).join('\n'));

    function compare(a, b) {
        if (a.length < b.length) {
            return  -1;
        } else if (a.length > b.length) {
            return 1;
        } else {
            if (a < b) {
                return - 1;
            } else if (a > b) {
                return 1;
            } else {
                return 0;
            }
        }
    }
}

/* sortAnArrayBy2Criteria(['alpha',
    'beta',
    'gama',
]); */