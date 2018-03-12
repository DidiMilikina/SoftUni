#include <iostream>
#include <string>
using namespace std;

int main() {
	int monets1;
	int monets2;
	int monets5;
	int sum;
	cin >> monets1 >> monets2 >> monets5 >> sum;

	for (int m1 = 0; m1 <= monets1; m1++)
	{
		for (int m2 = 0; m2 <= monets2; m2++)
		{
			for (int m5 = 0; m5 <= monets5; m5++)
			{
				if (m1 * 1 + m2 * 2 + m5 * 5 == sum)
				{
					cout << m1 << " * 1 lv. + " 
						<< m2 << " * 2 lv. + " 
						<< m5 << " * 5 lv. = " 
						<< sum << " lv." << endl;
				}
			}
		}
	}
}