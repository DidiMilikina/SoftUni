#include <iostream>
#include <iomanip>
#include <math.h>
using namespace std;

int main()
{
	double time_first_brother;
	double time_second_brother;
	double time_third_brother;
	double time_father_fishing;

	cin >> time_first_brother >> time_second_brother >> time_third_brother >> time_father_fishing;

	double time = 1 / (1 / time_first_brother + 1 / time_second_brother + 1 / time_third_brother);
	double time_with_relax = (time * 0.15) + time;
	double difference = time_father_fishing - time_with_relax;

	cout << "Cleaning time: " << fixed << setprecision(2) << time_with_relax << endl;

	if (difference >= 0)
	{
		cout << "Yes, there is a surprise - time left -> " << fixed << setprecision(0) << floor(difference) << " hours." << endl;
	}
	else
	{
		cout << "No, there isn't a surprise - shortage of time -> " << fixed << setprecision(0) << ceil(abs(difference)) << " hours." << endl;
	}
}