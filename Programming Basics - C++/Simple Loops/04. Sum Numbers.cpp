#include <iostream>
using namespace std;

int main() {
	int n;
	cin >> n;

	int m = 0;
	int sum = 0;
	for (int i = 1; i <= n; i++) {
		cin >> m;
		sum += m;
	}
	cout << sum << endl;
	return 0;
}