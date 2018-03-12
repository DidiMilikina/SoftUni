#include <iostream>
#include <string>
using namespace std;

int main() {
	string input;
	cin >> input;
	string right_pass = "s3cr3t!P@ssw0rd";

	if (input == right_pass)
	{
		cout << "Welcome" << endl;
	}
	else
	{
		cout << "Wrong password!" << endl;
	}
}