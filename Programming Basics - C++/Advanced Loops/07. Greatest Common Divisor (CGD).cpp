#include <iostream>
using namespace std;

int main() {
	int a, b;
	cin >> a >> b;

	while (b != 0)
	{
		int oldb = b;
		b = a % b;
		a = oldb;
	}
	cout << a << endl;
}