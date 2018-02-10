#include <iostream>
#include <string>
using namespace std;

int main() {
	int width_cake;
	int length_cake;
	string command;
	cin >> width_cake >> length_cake >> command;

	int left_pieces = width_cake * length_cake;
	int take_cake_pieces = 0;

	while (command != "STOP")
	{
		string to_take = command;
		int taken = atoi(to_take.c_str());
		
		left_pieces -= taken;

		if (take_cake_pieces > left_pieces)
		{
			break;
		}
		
		cin >> command;
	}

	if (take_cake_pieces > left_pieces)
	{
		int need_more_pieces = take_cake_pieces - left_pieces;
		cout << "No more cake left! You need " << need_more_pieces <<" pieces more." << endl;
	}
	else
	{
		cout << left_pieces << " pieces are left." << endl;
	}
}