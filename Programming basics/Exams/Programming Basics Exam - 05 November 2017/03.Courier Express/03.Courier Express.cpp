#include <iostream>
#include <string>
#include <iomanip>

using namespace std;

int main()
{
	double weight_in_kilos;
	string type_service;
	int distance_in_kilometers;
	cin >> weight_in_kilos >> type_service >> distance_in_kilometers;

	double price = 0;

	if (weight_in_kilos > 1 && weight_in_kilos < 11)
	{
		price = distance_in_kilometers * 0.05;
	}
	else if (weight_in_kilos > 10 && weight_in_kilos < 41)
	{
		price = distance_in_kilometers * 0.1;
	}
	else if (weight_in_kilos > 40 && weight_in_kilos < 91)
	{
		price = distance_in_kilometers * 0.15;
	}
	else if (weight_in_kilos > 90 && weight_in_kilos <= 150)
	{
		price = distance_in_kilometers * 0.20;
	}
	else
	{
		price = distance_in_kilometers * 0.03;
	}

	if (type_service == "express")
	{
		if (weight_in_kilos > 1 && weight_in_kilos < 11)
		{
			price = price + weight_in_kilos * distance_in_kilometers * 0.05 * 0.4;
		}
		else if (weight_in_kilos > 10 && weight_in_kilos < 41)
		{
			price = price + weight_in_kilos * distance_in_kilometers * 0.1 * 0.05;
		}
		else if (weight_in_kilos > 40 && weight_in_kilos < 91)
		{
			price = price + weight_in_kilos * distance_in_kilometers * 0.15 * 0.02;
		}
		else if (weight_in_kilos > 90 && weight_in_kilos <= 150)
		{
			price = price + weight_in_kilos * distance_in_kilometers * (0.20 * 0.01);
		}
		else
		{
			price = price + weight_in_kilos * distance_in_kilometers * 0.03 * 0.8;
		}
	}

	cout << "The delivery of your shipment with weight of "
		<< fixed << setprecision(3) << weight_in_kilos << " kg. would cost "
		<< fixed << setprecision(2) << price << " lv." << endl;

	return 0;
}