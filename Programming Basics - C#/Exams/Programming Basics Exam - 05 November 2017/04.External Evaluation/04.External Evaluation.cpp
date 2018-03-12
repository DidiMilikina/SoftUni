#include <iostream>
#include <string>
#include <iomanip>

using namespace std;

int main()
{
	double n;
	cin >> n;

	double poor_marks = 0;
	double satisfactory = 0;
	double good = 0;
	double very_good = 0;
	double excellent = 0;

	for (int i = 0; i < n; ++i)
	{
		double num;
		cin >> num;
		if (num > 0 && num <= 22.5)
		{
			poor_marks++;
		}
		else if (num > 22.5 && num <= 40.5)
		{
			satisfactory++;
		}
		else if (num > 40.5 && num <= 58.5)
		{
			good++;
		}
		else if (num > 58.5 && num <= 76.5)
		{
			very_good++;
		}
		else if (num > 76.5 && num <= 100)
		{
			excellent++;
		}
	}

	cout << fixed << setprecision(2) << poor_marks * 100 / n << "% poor marks" << endl;
	cout << fixed << setprecision(2) << satisfactory * 100 / n << "% satisfactory marks" << endl;
	cout << fixed << setprecision(2) << good * 100 / n << "% good marks" << endl;
	cout << fixed << setprecision(2) << very_good * 100 / n << "% very good marks" << endl;
	cout << fixed << setprecision(2) << excellent * 100 / n << "% excellent marks" << endl;

	return 0;
}