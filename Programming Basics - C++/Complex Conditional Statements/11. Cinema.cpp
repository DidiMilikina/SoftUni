#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

int main() {
	string type_projection;
	double rows, columns;

	cin >> type_projection >> rows >> columns;
	double seats = rows * columns;
	double price = 0;

	if (type_projection == "Premiere")
	{
		price = 12;
	}
	else if (type_projection == "Normal")
	{
		price = 7.5;
	}
	else
	{
		price = 5;
	}

	cout << fixed << setprecision(2) << seats * price << endl;
}