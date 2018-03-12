#include <iostream>
using namespace std;

int main() {
	int number;
	cin >> number;

	for (size_t i = 1; i <= number; i+=3)
	{
		cout << i << endl;
	}
}