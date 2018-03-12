#include <iostream>
#include <iomanip>
using namespace std;

int main() {
	double side, height;
	cin >> side >> height;

	double area = side * height / 2;
	cout << setprecision(2) << fixed << area << endl;
}