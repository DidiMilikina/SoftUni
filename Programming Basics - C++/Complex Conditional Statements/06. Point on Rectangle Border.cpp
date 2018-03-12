#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

int main() {

	double x1, y1, x2, y2, x, y;
	cin >> x1 >> y1 >> x2 >> y2 >> x >> y;
	bool on_left_side = (x == x1) && (y >= y1) && (y <= y2);
	bool on_right_side = (x == x2) && (y >= y1) && (y <= y2);
	bool on_up_side = (y == y1) && (x >= x1) && (x <= x2);
	bool on_down_side = (y == y2) && (x >= x1) && (x <= x2);
	if (on_left_side || on_right_side || on_up_side || on_down_side) {
		cout << "Border" << endl;
	}
	else {
		cout << "Inside / Outside" << endl;
	}

}