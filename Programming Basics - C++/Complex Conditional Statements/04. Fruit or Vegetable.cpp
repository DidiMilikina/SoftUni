#include <iostream>
#include<string>
using namespace std;

int main() {
	string fruit_or_vegetable;
	cin >> fruit_or_vegetable;

	bool fruit = fruit_or_vegetable == "banana" ||
		fruit_or_vegetable == "apple" ||
		fruit_or_vegetable == "kiwi" ||
		fruit_or_vegetable == "cherry" ||
		fruit_or_vegetable == "lemon" ||
		fruit_or_vegetable == "grapes";
	bool veg = fruit_or_vegetable == "tomato" ||
		fruit_or_vegetable == "cucumber" ||
		fruit_or_vegetable == "pepper" ||
		fruit_or_vegetable == "carrot";

	if (fruit)
	{
		cout << "fruit" << endl;
	}
	else if (veg)
	{
		cout << "vegetable" << endl;
	}
	else
	{
		cout << "unknown" << endl;
	}
}