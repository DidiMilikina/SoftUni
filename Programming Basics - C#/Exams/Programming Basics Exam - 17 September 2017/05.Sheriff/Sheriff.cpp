#include <iostream>
#include <string>
using namespace std;

int main()
{
	int number;
	cin >> number;

	int dots = 3 * number / 2 - 1;
	cout << string(3 * number / 2, '.') << "x" << string(3 * number / 2, '.') << endl;
	cout << string(dots, '.') << "/x\\" << string(dots, '.') << endl;
	cout << string(dots, '.') << "x|x" << string(dots, '.') << endl;

	for (int i = 0; i < number / 2; i++)
	{
		int dots_i = 3 * number / 2 - number - i;
		int hyks_i = number + i;
		cout << string(dots_i, '.') << string(hyks_i, 'x') << "|" << string(hyks_i, 'x') << string(dots_i, '.') << endl;
	}

	for (int j = number / 2; j >= 0; j--)
	{
		int dots_j = 3 * number / 2 - number - j;
		int hyks_j = number + j;
		cout << string(dots_j, '.') << string(hyks_j, 'x') << "|" << string(hyks_j, 'x') << string(dots_j, '.') << endl;
	}

	cout << string(dots, '.') << "/x\\" << string(dots, '.') << endl;
	cout << string(dots, '.') << "\\x/" << string(dots, '.') << endl;

	for (int k = 0; k < number / 2; k++)
	{
		int dots_k = 3 * number / 2 - number - k;
		int hyks_k = number + k;
		cout << string(dots_k, '.') << string(hyks_k, 'x') << "|" << string(hyks_k, 'x') << string(dots_k, '.') << endl;
	}

	for (int l = number / 2; l >= 0; l--)
	{
		int dots_l = 3 * number / 2 - number - l;
		int hyks_l = number + l;
		cout << string(dots_l, '.') << string(hyks_l, 'x') << "|" << string(hyks_l, 'x') << string(dots_l, '.') << endl;
	}

	cout << string(dots, '.') << "x|x" << string(dots, '.') << endl;
	cout << string(dots, '.') << "\\x/" << string(dots, '.') << endl;
	cout << string(3 * number / 2, '.') << "x" << string(3 * number / 2, '.') << endl;
}