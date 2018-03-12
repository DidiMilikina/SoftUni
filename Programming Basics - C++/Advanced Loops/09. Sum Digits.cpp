#include <iostream>
using namespace std;

int main() {
	int number;
	cin >> number;

	int sum = 0;
	do
	{
		int last_digit = number % 10;
		sum += last_digit;
		number /= 10;
	} while (number > 0);

	cout << sum << endl;
}