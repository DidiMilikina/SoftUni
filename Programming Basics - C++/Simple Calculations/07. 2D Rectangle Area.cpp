#include <iostream>
#include <cmath>
using namespace std;

int main() {
	double x1, y1, x2, y2;
	cin >> x1 >> y1 >> x2 >> y2;

	double area = abs(x2 - x1) * abs(y1 - y2);
	double peremeter = 2 * (abs(x2 - x1) + abs(y1 - y2));
	cout << area << endl;
	cout << peremeter << endl;
}