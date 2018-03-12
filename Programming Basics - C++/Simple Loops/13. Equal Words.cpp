#include <iostream>
#include <string>
using namespace std;

int main() {

	string word_one, word_two;
	cin >> word_one >> word_two;

	for (char i = 0; i < word_one.length(); ++i) {
		word_one[i] = tolower(word_one[i]);
		word_two[i] = tolower(word_two[i]);
	}

	if (word_one == word_two) cout << "yes" << endl;
	else cout << "no" << endl;

}