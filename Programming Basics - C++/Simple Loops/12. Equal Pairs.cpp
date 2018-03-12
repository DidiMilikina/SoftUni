#include <iostream>
using namespace std;

int main()
{
	int number;
	cin >> number;

	int sum = 0;
	int previous = 0;
	int difference = 0;
	int max_difference = 0;

	for (int i = 0; i < number; ++i)
	{
		int number1, number2;
		cin >> number1 >> number2;
		sum = number1 + number2;
		difference = abs(number1 + number2 - previous);
		previous = sum;
		if (difference > max_difference && sum != difference)
		{
			max_difference = difference;
		}
	}

	if (difference != 0 && sum != difference)
	{
		cout << "No, maxdiff=" << max_difference << endl;
	}
	else
	{
		cout << "Yes, value=" << sum << endl;
	}
	return 0;
}