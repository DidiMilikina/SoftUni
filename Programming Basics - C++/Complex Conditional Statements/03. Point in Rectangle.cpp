#include <string>
#include <iostream>
#include <cmath>

using namespace std;

int main()
{
	double x1, y1, x2, y2, x_of_point, y_of_point;
	double left, right, top, bottom;

	cin >> x1 >> y1 >> x2 >> y2 >> x_of_point >> y_of_point;

	left = fmin(x1, x2);
	right = fmax(x1, x2);
	top = fmin(y1, y2);
	bottom = fmax(y2, y1);

	bool is_inside = left <= x_of_point && x_of_point <= right && top <= y_of_point && y_of_point <= bottom;
	if (is_inside)
	{
		cout << "Inside" << endl;
	}
	else {
		cout << "Outside" << endl;
	}

	return 0;
}