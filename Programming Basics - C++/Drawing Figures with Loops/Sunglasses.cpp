#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

int main() {
	int n;
	cin >> n;

	cout << string(2 * n, '*');
	cout << string(n, ' ');
	cout << string(2 * n, '*') << endl;


	int noseIndex = (n - 1) / 2 - 1;

	for (int row = 0; row < n - 2; row++)
	{
		if (row != noseIndex)
		{
			cout << '*';
			cout << string(n * 2 - 2, '/');
			cout << '*';
			cout << string(n, ' ');
			cout << '*';
			cout << string(n * 2 - 2, '/');
			cout << '*' << endl;
		}
		else
		{
			cout << '*';
			cout << string(n * 2 - 2, '/');
			cout << '*';
			cout << string(n, '|');
			cout << '*';
			cout << string(n * 2 - 2, '/');
			cout << '*' << endl;
		}
	}

	cout << string(n * 2, '*');
	cout << string(n, ' ');
	cout << string(n * 2, '*') << endl;
}