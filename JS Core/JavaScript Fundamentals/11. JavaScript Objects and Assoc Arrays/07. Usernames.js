function usernames(input) {
    let usernamesSet = new Set();

    for (let username of input) {
        usernamesSet.add(username);
    }

    Array.from(usernamesSet.keys()).sort((a, b) => sortUsernames(a, b)).forEach(u => console.log(u));

    function sortUsernames(a, b) {
        if (a.length != b.length) {
            return (a.length - b.length);
        } else {
            return a.localeCompare(b);
        }
    }
}

/* usernames([
    "Denise", "Ignatius", "Iris", "Isacc", "Indie", "Dean", "Donatello", "Enfuego", "Benjamin", "Biser", "Bounty", "Renard", "Rot"
]); */