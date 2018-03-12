#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

int main()
{
	string fruit, day;
	double quantity;
	cin >> fruit >> day >> quantity;

	if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
	{
		if (fruit == "banana") cout << fixed << setprecision(2) << quantity*2.50 << endl;
		else if (fruit == "apple") cout << fixed << setprecision(2) << quantity*1.20 << endl;
		else if (fruit == "orange") cout << fixed << setprecision(2) << quantity*0.85 << endl;
		else if (fruit == "grapefruit") cout << fixed << setprecision(2) << quantity*1.45 << endl;
		else if (fruit == "kiwi") cout << fixed << setprecision(2) << quantity*2.70 << endl;
		else if (fruit == "pineapple") cout << fixed << setprecision(2) << quantity*5.50 << endl;
		else if (fruit == "grapes") cout << fixed << setprecision(2) << quantity*3.85 << endl;
		else cout << "error" << endl;
	}
	else if (day == "Saturday" || day == "Sunday")
	{
		if (fruit == "banana") cout << fixed << setprecision(2) << quantity*2.70 << endl;
		else if (fruit == "apple") cout << fixed << setprecision(2) << quantity*1.25 << endl;
		else if (fruit == "orange") cout << fixed << setprecision(2) << quantity*0.90 << endl;
		else if (fruit == "grapefruit") cout << fixed << setprecision(2) << quantity*1.60 << endl;
		else if (fruit == "kiwi") cout << fixed << setprecision(2) << quantity*3.00 << endl;
		else if (fruit == "pineapple") cout << fixed << setprecision(2) << quantity*5.60 << endl;
		else if (fruit == "grapes") cout << fixed << setprecision(2) << quantity*4.20 << endl;
		else cout << "error" << endl;
	}
	else cout << "error" << endl;
	return 0;
}