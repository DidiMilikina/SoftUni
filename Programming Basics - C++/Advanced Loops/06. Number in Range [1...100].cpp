#include <iostream>
using namespace std; 

int main() {
	cout << "Enter a number in the range[1...100]: ";
	
	int valid_number;
	cin >> valid_number;
	
	while (valid_number < 1 || valid_number > 100)
	{
		cout << "Invalid number!" << endl;
		cin >> valid_number;
	}

	cout << "The number is: " << valid_number << endl;
}