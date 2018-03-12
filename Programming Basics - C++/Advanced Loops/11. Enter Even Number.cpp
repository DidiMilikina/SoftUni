#include <iostream>
#include <string>
using namespace std;

int main() {

	int number;
	do
	{
		try
		{
			cout << "Enter even number : " << endl;
			cin >> number;
			if (number % 2 == 0)
			{
				break;
			}
			cout << "The number is not even." << endl;
			cout << "Enter even number: " << endl;
			cin >> number;
		}
		catch (const std::exception&)
		{
			cout << "Invalid number!" << endl;
		}
	} while (true);
	{
		cout << "Even number entered: " << number << endl;
	}
	return 0;
}