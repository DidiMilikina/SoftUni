#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

int main()
{
	double area;
	string geometry_figure;
	cin >> geometry_figure;


	if (geometry_figure == "square")
	{
		double side_a;
		cin >> side_a;
		area = side_a * side_a;
	}
	else if (geometry_figure == "rectangle")
	{
		double side_b, side_c;
		cin >> side_b >> side_c;
		area = side_b * side_c;
	}
	else if (geometry_figure == "circle")
	{
		double radius;
		double pi = 3.14159265359;
		cin >> radius;
		area = pi * radius * radius;
	}
	else  if (geometry_figure == "triangle")
	{
		double width, hight;
		cin >> width >> hight;
		area = (width * hight) / 2;
	}

	cout << fixed << setprecision(3) << area << endl;

	return 0;
}