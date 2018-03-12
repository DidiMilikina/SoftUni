#include <iostream>
using namespace std;

int main() {
	int number;
	cin >> number;
	
	int odd_sum = 0;
	int even_sum = 0;
	
	for (int i = 0; i < number; i++)
	{
		int current_num;
		cin >> current_num;
		
		if (i % 2 == 0)
		{
			even_sum += current_num;
		}
		else
		{
			odd_sum += current_num;
		}

	}
	if (odd_sum == even_sum)
	{
		cout << "Yes" << endl;
		cout << "Sum = " << odd_sum << endl;
	}
	else
	{
		int diff = abs(odd_sum - even_sum);
		cout << "No" << endl;
		cout << "Diff = " << diff << endl;
	}
}