#include <iostream>
#include <string>
using namespace std;

int main(){
	int first, secound, third, totalTimes, printHour, printMinutes;
	cin >> first >> secound >> third;

	totalTimes = first + secound + third;
	printHour = totalTimes / 60;
	printMinutes = totalTimes % 60;

	if (printHour >= 24)
	{
		printHour %= 24;
		cout << printHour << ":";
	}
	else
	{
		cout << printHour << ":";
	}

	if (printMinutes <= 9) 
	{
		cout << "0" << printMinutes << endl;
	}
	else 
	{
		cout << printMinutes << endl;
	}
}