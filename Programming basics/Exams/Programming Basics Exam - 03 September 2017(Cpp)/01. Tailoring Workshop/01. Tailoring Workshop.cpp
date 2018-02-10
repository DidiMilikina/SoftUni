#include <iostream>
#include <iomanip>
using namespace std;

int main() {
	double number_rectangular_tables;
	double length_rectangular_tables;
	double width_rectangular_tables;

	cin >> number_rectangular_tables >> length_rectangular_tables >> width_rectangular_tables;

	double total_area_cover =
		number_rectangular_tables * (length_rectangular_tables + 2 * 0.3)
		* (width_rectangular_tables + 2 * 0.3);

	double total_area_square = number_rectangular_tables * (length_rectangular_tables / 2)
		* (length_rectangular_tables / 2);

	double price_in_dolars = total_area_cover * 7 + total_area_square * 9;
	double price_in_leva = price_in_dolars * 1.85;

	cout << fixed << setprecision(2) << price_in_dolars << " USD" << endl;
	cout << fixed << setprecision(2) << price_in_leva << " BGN" << endl;
}