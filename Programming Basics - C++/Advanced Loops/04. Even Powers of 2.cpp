#include <iostream>
using namespace std;

int main() {
	int num = 1;
	int n;
	cin >> n;

	for (int i = 0; i <= n; i += 2)
	{
		cout << num << endl;
		num = num * 2 * 2;
	}
}