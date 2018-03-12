#include <iostream>
using namespace std;

int main() {
	int number; 
	cin >> number;

	int factorial = 1;
	do
	{
		factorial = factorial * number;
		number--;
	} while (number > 1);

	cout << factorial << endl;
}