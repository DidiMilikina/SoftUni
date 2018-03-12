#include <iostream>
using namespace std;

int main()
{
	int rowNum, rowWidth;
	for (rowNum = 1; rowNum <= 10; rowNum++) //10 редa
	{
		for (rowWidth = 1; rowWidth <= rowNum; rowWidth++)
		{
			cout << "*";
		}

		cout << "\n";
	}
	return 0;
}