#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

int main()
{
	double radians;
	cin >> radians;

	double pi = 3.1415;
	double celsuim = radians * (180 / pi);

	cout << fixed << setprecision(0) << celsuim << endl;
	return 0;
}