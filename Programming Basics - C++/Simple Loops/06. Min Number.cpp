#include <iostream>
using namespace std;

int main() {
	int n;
    cin >> n;
	int number;
	int min = 2147000000;
	
	for (int i = 0; i < n; i++)
	{
		cin >> number;
		if (number < min)
		{
			min = number;
		}
	}
	cout << min << endl;
}