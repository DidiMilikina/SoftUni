#include <iostream>
using namespace std;

int main()
{
	int n;
	cin >> n;

	for (int i = 1; i <= 9; ++i)
	{
		for (int j = 1; j <= 9; ++j)
		{
			for (int k = 1; k <= 9; ++k)
			{
				for (int l = 1; l <= 9; ++l)
				{
					int first_sum = i + j;
					int second_sum = k + l;
					if (first_sum == second_sum && n % first_sum == 0)
					{
						cout << i << j << k << l << ' ';
					}
				}
			}
		}
	}

	return 0;
}