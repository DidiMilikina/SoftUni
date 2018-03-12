#include <iostream>
#include <string>
using namespace std;

int main() {
	string word;
	getline(cin, word);

	int sum = 0;
	for (int i = 0; i < word.size(); i++)
	{
		int current_letter = word[i];
		if (current_letter == 'a')
		{
			sum += 1;
		}
		if (current_letter == 'e')
		{
			sum += 2;
		}
		if (current_letter == 'i')
		{
			sum += 3;
		}
		if (current_letter == 'o')
		{
			sum += 4;
		}
		if (current_letter == 'u')
		{
			sum += 5;
		}
	}
	cout << sum << endl;
}