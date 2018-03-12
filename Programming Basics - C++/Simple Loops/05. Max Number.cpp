#include <iostream>
#include <string>
#include <climits>
using namespace std;

int main() {
	int n, number; cin >> n;

	int max = INT_MIN;

	for (int i = 1; i <= n; i++) {
		cin >> number;
		if (number > max) {
			max = number;
		}
	}
	cout << max << endl;
}