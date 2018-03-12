#include <iostream>
#include <string>
using namespace std;

int main() {
	double age;
	string gender;
	cin >> age >> gender;

	if (gender == "m") 
	{
		if (age < 16) 
		{
			cout << "Master";
		}
		else if (age >= 16) 
		{
			cout << "Mr.";
		}
	}
	else if (gender == "f") 
	{
		if (age < 16) 
		{
			cout << "Miss";
		}
		else if (age >= 16) 
		{
			cout << "Ms.";
		}
	}
}