#include <iostream>
#include <string>
using namespace std;

int main() {

	int number;
	cin >> number;

	int width = 2 * number + 3;
	int length = 2 * number + 1;

	int points_middle = number;
	for (int i = 0; i < number - 1; i++)
	{
		cout << string(i, '.');
		cout << '*';
		cout << string(points_middle, '.');
		cout << '*';
		cout << string(points_middle, '.');
		cout << '*';
		cout << string(i, '.') << endl;
		points_middle--;
	}

	int points_second = number - 1;
	cout << string(points_second, '.');
	cout << "*****";

	cout << string(points_second, '.') << endl;
	cout << string(width, '*') << endl;
	cout << string(points_second, '.');
	cout << string(5, '*');
	cout << string(points_second, '.') << endl;

	int points_end = number - 2;
	int points_middleEnd = 2;
	for (int i = number - 1; i > 0; i--)
	{
		cout << string(points_end, '.');
		cout << '*';
		cout << string(points_middleEnd, '.');
		cout << '*';
		cout << string(points_middleEnd, '.');
		cout << '*';
		cout << string(points_end, '.') << endl;
		points_end--;
		points_middleEnd++;
	}
}