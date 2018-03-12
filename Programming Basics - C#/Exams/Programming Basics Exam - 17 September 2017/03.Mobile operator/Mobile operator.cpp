#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

int main()
{
	string duration_contract;
	string type_contract;
	string added_network;
	int months_of_payment;
	cin >> duration_contract >> type_contract >> added_network >> months_of_payment;

	double sum = 0;
	if (duration_contract == "one")
	{
		if (type_contract == "Small")
		{
			sum = 9.98;
		}
		else if (type_contract == "Middle")
		{
			sum = 18.99;
		}
		else if (type_contract == "Large")
		{
			sum = 25.98;
		}
		else if (type_contract == "ExtraLarge")
		{
			sum = 35.99;
		}
	}
	else if (duration_contract == "two")
	{
		if (type_contract == "Small")
		{
			sum = 8.58;
		}
		else if (type_contract == "Middle")
		{
			sum = 17.09;
		}
		else if (type_contract == "Large")
		{
			sum = 23.59;
		}
		else if (type_contract == "ExtraLarge")
		{
			sum = 31.79;
		}
	}
	if (added_network == "yes")
	{
		if (sum <= 10) {
			sum = sum + 5.50;
		}
		else if (sum <= 30) {
			sum = sum + 4.35;
		}
		else {
			sum = sum + 3.85;
		}
	}
	if (duration_contract == "two") {
		sum = sum - (sum * 0.0375);
	}

	double total = sum * months_of_payment;
	cout << fixed << setprecision(2) << total << " lv."<< endl;
}