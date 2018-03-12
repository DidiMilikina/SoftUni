#include <string>
#include <iostream>
#include <iomanip>
#include <cmath>
using namespace std;

int main()
{

	string year;
	double holidays, weekends_return_home;
	cin >> year >> holidays >> weekends_return_home;

	double weekends = (48 - weekends_return_home) * 3 / 4;
	double play_in_Sofia = holidays * 2 / 3;
	double total_play = weekends + 
		play_in_Sofia + 
		weekends_return_home;

	double play = total_play;
	if(year == "leap")
	{
		play *= 1.15;
		cout << floor(play) << endl;
	}
	else if(year == "normal")
	{
		cout << floor(total_play) << endl;
	}
	return 0;
}