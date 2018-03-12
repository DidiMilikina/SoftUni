#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	int n;
	cin >> n;
	int m = n;

	if (n == 0)
		cout << "zero\n";
	else if (n <= 10)
	{
		switch (n)
		{
		case 1:
			cout << "one\n"; break;
		case 2:
			cout << "two\n"; break;
		case 3:
			cout << "three\n"; break;
		case 4:
			cout << "four\n"; break;
		case 5:
			cout << "five\n"; break;
		case 6:
			cout << "six\n"; break;
		case 7:
			cout << "seven\n"; break;
		case 8:
			cout << "eight\n"; break;
		case 9:
			cout << "nine\n"; break;
		case 10:
			cout << "ten\n"; break;

		}
	}
	else if (n > 10 && n < 20)
	{
		m %= 10;
		switch (m)
		{
		case 1:
			cout << "eleven\n"; break;
		case 2:
			cout << "twelve\n"; break;
		case 3:
			cout << "thirteen\n"; break;
		case 4:
			cout << "fourteen\n"; break;
		case 5:
			cout << "fifteen\n"; break;
		case 6:
			cout << "sixteen\n"; break;
		case 7:
			cout << "seventeen\n"; break;
		case 8:
			cout << "eighteen\n"; break;
		case 9:
			cout << "nineteen\n"; break;
		}
	}
	else if (n > 19 && n < 100)
	{
		m /= 10;

		switch (m)
		{
		case 2:
			cout << "twenty"; break;
		case 3:
			cout << "thirty"; break;
		case 4:
			cout << "forty"; break;
		case 5:
			cout << "fifty"; break;
		case 6:
			cout << "sixty"; break;
		case 7:
			cout << "seventy"; break;
		case 8:
			cout << "eighty"; break;
		case 9:
			cout << "ninety"; break;
		}

		if (n / 10 != 0)
		{
			m = n;
			m %= 10;

			switch (m)
			{
			case 1:
				cout << " one\n"; break;
			case 2:
				cout << " two\n"; break;
			case 3:
				cout << " three\n"; break;
			case 4:
				cout << " four\n"; break;
			case 5:
				cout << " five\n"; break;
			case 6:
				cout << " six\n"; break;
			case 7:
				cout << " seven\n"; break;
			case 8:
				cout << " eight\n"; break;
			case 9:
				cout << " nine\n"; break;
			}
		}
	}
	else if (n == 100)
	{
		cout << "one hundred\n";
	}
	if (n < 0 || n > 100)
	{
		cout << "invalid number\n";
	}

	return 0;
}