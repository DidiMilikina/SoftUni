#include <iostream>
#include <string>
using namespace std;

int main() {
	string first_name, second_name, age, town;
	getline(cin, first_name);
	getline(cin, second_name);
	getline(cin, age);
	getline(cin, town);

	cout << "You are " << first_name << " " << second_name << ", a " << age << "-years old person from " << town << ".";
	cout << endl;
}