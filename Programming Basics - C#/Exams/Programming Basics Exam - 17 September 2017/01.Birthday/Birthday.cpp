#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	int length;
	int width;
	int height;
	double percent;
	cin >> length >> width >> height >> percent;

	int volume = length * width * height;
	double total = volume * 0.001;
	double percents = percent * 0.01;
	double result = total * (1 - percents);

	cout << fixed << setprecision(3) << result << endl;
}