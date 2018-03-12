#include <iostream>
using namespace std;

int main() {
	int number;
	cin >> number;

	int num = 1;
	while (num <= number)
	{
		cout << num << endl;
		num = num * 2 + 1;
	}
}