#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

int main() {
	int n;
	cin >> n;

	for (int row = 1; row <= n; row++)
	{
		for (int col = 1; col <= n - row; col++)
		{
			cout << " ";
		}
		cout << "*";
		for (int col = 1; col < row; col++)
		{
			cout << " *";
		}
		cout << endl;
	}

	for (int row = n - 1; row >= 1; row--)
	{
		for (int col = 1; col <= n - row; col++)
		{
			cout << " ";
		}
		cout << "*";
		for (int col = 1; col < row; col++)
		{
			cout << " *";
		}
		cout << endl;
	}
}