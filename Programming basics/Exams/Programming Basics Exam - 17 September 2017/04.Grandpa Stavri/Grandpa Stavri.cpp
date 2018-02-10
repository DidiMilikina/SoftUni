#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	int number_days;
	cin >> number_days;

	double total_litres = 0;
	double total_degrees = 0;
	for (int i = 0; i < number_days; ++i)
	{
		double litres;
		double degree;
		cin >> litres >> degree;

		total_litres += litres;
		total_degrees += litres * degree;
	}

	double degrees = total_degrees / total_litres;

	cout << "Liter: "<<fixed << setprecision(2) << total_litres << endl;
	cout << "Degrees: " << fixed << setprecision(2) << degrees << endl;

	if (degrees < 38)
	{
		cout << "Not good, you should baking!" << endl;
	}
	else if (degrees >= 38 && degrees <= 42)
	{
		cout << "Super!" << endl;
	}
	else if (degrees > 42)
	{
		cout << "Dilution with distilled water!" << endl;
	}
}