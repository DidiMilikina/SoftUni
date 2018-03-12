#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

int main() {
	int number;
	cin >> number;

	cout << "+";
	for (size_t i = 0; i < number - 2; i++)
		cout << " -";
	cout << " +" << endl;

	for (size_t row = 0; row < number - 2; row++) 
	{
		cout << "| ";
		for (size_t col = 0; col < number - 2; col++)
			cout << "- ";
		cout << "|" << endl;

	}

	cout << "+";
	for (size_t i = 0; i < number - 2; i++)
		cout << " -";
	cout << " +" << endl;
}