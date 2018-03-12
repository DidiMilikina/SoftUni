#include <iostream>
using namespace std;

int main() {
	int number;
	cin >> number;

	int current_num = 1;
	int row = 1;
	while (current_num <= number)
	{
		for (int i = 0; i < row; i++)
		{
			if (current_num > number)
			{
				break;
			}
			cout << current_num << " ";
			current_num++;
		}
		row++;
		cout << endl;
	}
}