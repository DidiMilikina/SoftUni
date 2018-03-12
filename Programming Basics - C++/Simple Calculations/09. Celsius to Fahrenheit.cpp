#include <iostream>
#include <iomanip>
using namespace std;

int main() {
	double celsius;
	cin >> celsius;
	double fahrenheit;
	fahrenheit = celsius * 9 / 5 + 32;
	cout << fahrenheit << endl;
}