#include <iostream>
#include <cmath>
using namespace std;

int main()
{
	double kilograms_tomatoes;
	double number_boxes;
	double number_jars;
	cin >> kilograms_tomatoes >> number_boxes >> number_jars;

	double total_lutenitsa = kilograms_tomatoes / 5.00;
	double jars = total_lutenitsa / 0.535;
	double boxes = jars / number_jars;

	cout << "Total lutenica: " << floor(total_lutenitsa) << " kilograms." << endl;

	if (boxes >= number_boxes)
	{
		cout << floor(boxes - number_boxes) << " boxes left." << endl;
		cout << floor(jars - (number_boxes * number_jars)) << " jars left." << endl;
	}
	else
	{
		cout << floor(number_boxes - boxes) << " more boxes needed." << endl;
		cout << floor(number_boxes * number_jars - jars) << " more jars needed." << endl;
	}

	return 0;
}