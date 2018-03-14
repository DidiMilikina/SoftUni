function jsonTable(input) {
    let html = '<table>\n';
    for (let line of input) {
        let obj = JSON.parse(line);
        html += `    <tr>\n       <td>${htmlEscape(obj.name)}</td>\n       <td>${htmlEscape(obj.position)}</td>\n       <td>${obj.salary}</td>\n    <tr>\n`;
    }
    html += '</table>';

    console.log(html);

    function htmlEscape(text) {
        let map = {
            '"': '&quot;',
            '&': '&amp;',
            "'": '&#39;',
            '<': '&lt;',
            '>': '&gt;'
        };
        return text.replace(/[\"&'<>]/g, ch => map[ch]);
    }
}

/* jsonTable(['{"name":"Pesho","position":"Promenliva","salary":100000}',
    '{"name":"Teo","position":"Lecturer","salary":1000}'
]); */