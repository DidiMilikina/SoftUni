#include <iostream>
using namespace std;

int main() {
	int number;
	cin >> number;

	int num = 1;
	for (int i = 0; i <= number; i++) 
	{
		cout << num << endl;
		num = num * 2;
	}
}