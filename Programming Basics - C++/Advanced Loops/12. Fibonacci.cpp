#include <iostream>
#include <string>
#include <cmath>
using namespace std;

int main() {
	int n;
	cin >> n;

	int f0 = 0;
	int f1 = 1;
	for (int i = 0; i < n; i++)
	{
		int fNext = f0 + f1;
		f0 = f1;
		f1 = fNext;
	}
	cout << f1 << endl;
}