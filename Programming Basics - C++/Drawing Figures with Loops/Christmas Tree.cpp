#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

int main() {
	int number;
	cin >> number;

	for (size_t i = 0; i <= number; i++)
	{
		string spaces = string(number - i, ' ');
		string stars = string(i, '*');
		cout << string(spaces);
		cout << string(stars);
		cout << " | ";
		cout << string(stars);
		cout << string(spaces) << endl;
	}
}
