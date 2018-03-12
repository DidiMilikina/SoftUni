#include <iostream>
#include <string>
using namespace std;

int main()
{
	string animal;
	cin >> animal;

	if (animal == "dog") 
	{
		cout << "mammal" << endl;
	}
	else if (animal == "snake" || animal == "crocodile" || animal == "tortoise")
	{
		cout << "reptile" << endl;
	}
	else 
	{
		cout << "unknown" << endl;
	}
}