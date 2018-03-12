#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

int main() {

	double money;
	string in_currency;
	string out_currency;
	cin >> money;
	cin >> in_currency >> out_currency;

	string currency = " BGN";


	if (in_currency == "USD")
	{
		money *= 1.79549;
	}
	else if (in_currency == "EUR")
	{
		money *= 1.95583;
	}
	else if (in_currency == "GBP")
	{
		money *= 2.53405;
	}

	if (out_currency == "USD")
	{
		money /= 1.79549;
		currency = " USD";
	}
	else if (out_currency == "EUR")
	{
		money /= 1.95583;
		currency = " EUR";
	}
	else if (out_currency == "GBP")
	{
		money /= 2.53405;
		currency = " GBP";
	}

	cout << fixed << setprecision(2) << money << currency << endl;
	return 0;
}
