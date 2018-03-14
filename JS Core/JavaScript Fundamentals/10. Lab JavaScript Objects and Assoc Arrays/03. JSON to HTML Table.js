function JSONToHTMLTable(json) {
    let html = '<table>\n';
    let array = JSON.parse(json);
    html += '  <tr>';

    for (let key of Object.keys(array[0])) {
        html += `<th>${htmlEscape(key)}</th>`;
    }

    html += '</tr>\n';

    for (let obj of array) {
        html += '   <tr>';
        for (let value of Object.keys(obj)) {
            html += '<td>' + htmlEscape(obj[value]) + '</td>';
        }
        html += '</tr>\n';
    }
    return html + '</table>';

    function htmlEscape(key) {
        let replaced = key.toString();

        replaced = replaced.split('&').join('&amp;');
        replaced = replaced.split('<').join('&lt;');
        replaced = replaced.split('>').join('&gt;');
        replaced = replaced.split('"').join('&quot;');
        replaced = replaced.split('\'').join('&#39;');

        return replaced;
    }
}

/* console.log(JSONToHTMLTable(['[{"Name":"Tomatoes & Chips","Price":2.35},{"Name":"J&B Chocolate","Price":0.96}]'])); */