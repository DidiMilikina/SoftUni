#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

int main() {

	int number_pictures;
	string type_picture;
	string online_or_office;
	cin >> number_pictures >> type_picture >> online_or_office;

	double discount = 0;
	double price_per_photo = 0;

	if (type_picture == "9X13")
	{
		price_per_photo = 0.16;
		if (number_pictures >= 50)
		{
			discount = 0.05;
		}
	}

	else if (type_picture == "10X15")
	{
		price_per_photo = 0.16;
		if (number_pictures >= 80)
		{
			discount = 0.03;
		}
	}

	else if (type_picture == "13X18")
	{
		price_per_photo = 0.38;

		if (number_pictures >= 50 && number_pictures <= 100)
		{
			discount = 0.03;
		}
		else if (number_pictures > 100)
		{
			discount = 0.05;
		}
	}

	else if (type_picture == "20X30")
	{
		price_per_photo = 2.9;

		if (number_pictures >= 10 && number_pictures <= 50)
		{
			discount = 0.07;
		}
		else if (number_pictures > 50)
		{
			discount = 0.09;
		}
	}

	double price = price_per_photo * number_pictures;
	double discount_price = (1 - discount) * price;

	if (online_or_office == "online")
	{
		discount_price = discount_price * 0.98;
	}

	cout << fixed << setprecision(2) << discount_price << "BGN" << endl;
}