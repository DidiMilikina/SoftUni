#include <iostream>
#include <string>
using namespace std;

int main() {
	string product, town;
	double price;
	cin >> product >> town >> price;

	if (town == "Sofia") 
	{
		if (product == "coffee") 
		{
			cout << price * 0.5 << endl;
		}
		else if (product == "water") 
		{
			cout << price * 0.8 << endl;
		}
		else if (product == "beer")
		{
			cout << price * 1.2 << endl;
		}
		else if (product == "sweets") 
		{
			cout << price * 1.45 << endl;
		}
		else if (product == "peanuts") 
		{
			cout << price * 1.6 << endl;
		}
	}

	if (town == "Varna") 
	{
		if (product == "coffee") 
		{
			cout << price * 0.45 << endl;
		}
		else if (product == "water") 
		{
			cout << price * 0.7 << endl;
		}
		else if (product == "beer") 
		{
			cout << price * 1.1 << endl;
		}
		else if (product == "sweets") 
		{
			cout << price * 1.35 << endl;
		}
		else if (product == "peanuts") 
		{
			cout << price * 1.55 << endl;
		}
	}

	if (town == "Plovdiv") 
	{
		if (product == "coffee") 
		{
			cout << price * 0.4 << endl;
		}
		else if (product == "water") 
		{
			cout << price * 0.7 << endl;
		}
		else if (product == "beer") 
		{
			cout << price * 1.15 << endl;
		}
		else if (product == "sweets") 
		{
			cout << price * 1.30 << endl;
		}
		else if (product == "peanuts") 
		{
			cout << price * 1.5 << endl;
		}
	}
}