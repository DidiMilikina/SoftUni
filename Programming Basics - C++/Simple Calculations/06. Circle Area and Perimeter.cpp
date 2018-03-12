#include <iostream>
#include <cmath>
using namespace std;

int main() {
	double r;
	cin >> r;

	// PI = 4 * atan(1);
	double area = 4 * atan(1) * r * r;
	double perimeter = 2 * 4 * atan(1) * r;
	
	cout << area << endl;
	cout << perimeter << endl;
}