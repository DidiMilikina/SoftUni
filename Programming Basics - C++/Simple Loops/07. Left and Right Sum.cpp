#include <iostream>
using namespace std;

int main() {
	int number;
	cin >> number;

	int left_sum = 0;
	for (size_t i = 0; i < number; i++)
	{
		int current_num = 0;
		cin >> current_num;
		left_sum += current_num;
	}

	int right_sum = 0;
	for (size_t i = 0; i < number; i++)
	{
		int current_num = 0;
		cin >> current_num;
		right_sum += current_num;
	}

	if (left_sum == right_sum)
	{
		cout << "Yes, sum = " << right_sum << endl;
	}
	else {
		int diff = abs(left_sum - right_sum);
		cout << "No, diff = " << diff << endl;
	}
}