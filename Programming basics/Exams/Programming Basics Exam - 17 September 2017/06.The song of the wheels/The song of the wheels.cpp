#include <iostream>
#include <string>
using namespace std;

int main()
{
	int number;
	cin >> number;

	int counter = 0;
	int pass = 0;
	string output = "";
	for (int first_num = 1; first_num <= 9; first_num++)
	{
		for (int second_num = 1; second_num <= 9; second_num++)
		{
			for (int third_num = 1; third_num <= 9; third_num++)
			{
				for (int fourht_num = 1; fourht_num <= 9; fourht_num++)
				{
					if (first_num * second_num + (third_num * fourht_num) == number)
					{
						if ((first_num < second_num) && (third_num > fourht_num))
						{
							cout << first_num << second_num << third_num << fourht_num << " ";
							counter++;

							if (counter == 4)
							{
								output = "" + std::to_string(first_num) + std::to_string(second_num) + std::to_string(third_num) + std::to_string(fourht_num);
							}
						}
					}
				}
			}
		}
	}
	cout << endl;
	if (counter == 1)
	{
		cout << "No!" << endl;
		return 0;
	}
	if (counter >= 4)
	{
		cout << "Password: " << output<< endl;
	}
	else
	{
		cout << "No!" << endl;
	}
	return 0;
}