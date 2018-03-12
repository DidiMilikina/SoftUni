#include <iostream>
using namespace std;

int main() {
	double first_num, second_num, third_num;
	cin >> first_num >> second_num >> third_num;

	if (first_num == second_num && second_num == third_num)
	{
		cout << "yes" << endl;
	}
	else
	{
		cout << "no" << endl;
	}
}