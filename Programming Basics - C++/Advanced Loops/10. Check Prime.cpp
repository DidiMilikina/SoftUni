#include <iostream>
#include<math.h>
using namespace std;

int main() {
	int number;
	cin >> number;

	bool is_prime = true;
	int sqrt_num = sqrt(number);

	if (number >= 2)
	{
		for (size_t i = 2; i <= sqrt_num; i++)
		{
			if (number % i == 0)
			{
				is_prime = false;
				break;
			}
		}
		if (is_prime)
		{
			cout << "Prime" << endl;
		}
		else {
			cout << "Not prime" << endl;
		}
	}
	else {
		cout << "Not prime" << endl;
	}
}