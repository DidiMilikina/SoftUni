#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

int main() {
	int n;
	cin >> n;

	if (n == 1)
	{
		cout << '*';
		return 0;
	}
	if (n == 2)
	{
		cout << "**";
		return 0;
	}

	if (n % 2 == 0)
	{
		int numberOfStars = 2;
		int numberOfDashes = (n - numberOfStars) / 2;
		cout << string(numberOfDashes, '-');
		cout << string(numberOfStars, '*');
		cout << string(numberOfDashes, '-') << endl;
	}
	else
	{
		int numberOfStars = 1;
		int numberOfDashes = (n - numberOfStars) / 2;
		cout << string(numberOfDashes, '-');
		cout << string(numberOfStars, '*');
		cout << string(numberOfDashes, '-') << endl;
	}

	int numberOfDashesInMiddle = 0;
	if (n % 2 == 0)
	{
		numberOfDashesInMiddle = 2;
	}
	else
	{
		numberOfDashesInMiddle = 1;
	}

	int numberOfRows = (n - 1) / 2;
	for (int i = 0; i < numberOfRows; i++)
	{
		int numberOfDashesInEnd = (n - 2 - numberOfDashesInMiddle) / 2;
		cout << string(numberOfDashesInEnd, '-');
		cout << '*';
		cout << string(numberOfDashesInMiddle, '-');
		cout << '*';
		cout << string(numberOfDashesInEnd, '-') << endl;
		numberOfDashesInMiddle += 2;
	}

	numberOfRows--;
	numberOfDashesInMiddle -= 2;
	for (int i = numberOfRows - 1; i >= 0; i--)
	{
		numberOfDashesInMiddle -= 2;
		int numberOfDashesInEnd = (n - 2 - numberOfDashesInMiddle) / 2;
		cout << string(numberOfDashesInEnd, '-');
		cout << '*';
		cout << string(numberOfDashesInMiddle, '-');
		cout << '*';
		cout << string(numberOfDashesInEnd, '-') << endl;

	}

	if (n % 2 == 0)
	{
		int numberOfStars = 2;
		int numberOfDashes = (n - numberOfStars) / 2;
		cout << string(numberOfDashes, '-');
		cout << string(numberOfStars, '*');
		cout << string(numberOfDashes, '-') << endl;
	}
	else
	{
		int numberOfStars = 1;
		int numberOfDashes = (n - numberOfStars) / 2;
		cout << string(numberOfDashes, '-');
		cout << string(numberOfStars, '*');
		cout << string(numberOfDashes, '-') << endl;
	}
}