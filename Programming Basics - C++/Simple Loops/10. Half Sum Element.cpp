#include <iostream>
#include <string>
#include <climits>
using namespace std;

int main() {
	int n;
	cin >> n;
	int greatestNumber = INT_MIN;
	int sum = 0;
	for (int i = 0; i < n; i++)
	{
		int currentNumber;
		cin >> currentNumber;
		sum += currentNumber;

		if (currentNumber > greatestNumber)
		{
			greatestNumber = currentNumber;
		}
	}


	sum -= greatestNumber;
	if (sum == greatestNumber)
	{
		cout << "Yes" << endl;
		cout << "Sum = " << sum << endl;
	}
	else
	{
		int difference = abs(sum - greatestNumber);
		cout << "No" << endl;
		cout << "Diff = " << difference << endl;
	}
}