#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
	double lenght_area_meters;
	double width_area_meters;
	double height_net_meters;
	double price_one_meter;
	double kilos_one_meter;
	cin >> lenght_area_meters >> width_area_meters >> height_net_meters
		>> price_one_meter >> kilos_one_meter;

	double total_net = 2 * lenght_area_meters + 2 * width_area_meters;
	double price_net = total_net * price_one_meter;
	double area_net = total_net * height_net_meters;
	double weight_net = area_net * kilos_one_meter;

	cout << total_net << endl;
	cout << fixed << setprecision(2) << price_net << endl;
	cout << fixed << setprecision(3) << weight_net << endl;


		return 0;
}
