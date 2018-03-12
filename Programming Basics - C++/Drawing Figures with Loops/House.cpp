#include <iostream>
#include <string>

using namespace std;

int main()
{
	int size;
	cin >> size;
	string stars, line;
	int number_of_stars = 1;
	int number_of_lines;

	//roof
	if (size % 2 == 0)
	{
		number_of_stars = 2;
	}

	for (int row = 0; row < (size + 1) / 2; row++)
	{
		stars = string(number_of_stars, '*');
		number_of_lines = (size - number_of_stars) / 2;
		line = string(number_of_lines, '-');

		cout << line << stars << line << endl;
		number_of_stars += 2;
	}

	//body
	for (int row = 0; row < size / 2; row++)
	{
		number_of_stars = size - 2;
		stars = string(number_of_stars, '*');
		cout << "|" << stars << "|" << endl;
	}

	return 0;
}