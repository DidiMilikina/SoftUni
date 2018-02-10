#include <iostream>
#include <math.h>
using namespace std;

int main() {
	double income_in_lv;
	double average;
	double minimal_salary;
	cin >> income_in_lv >> average >> minimal_salary;

	double social = 0;
	double excellent_grade = 0;

	if ((average > 4.5) && (income_in_lv < minimal_salary))
	{
		social = floor(minimal_salary * 0.35);
	}

	if (average >= 5.5)
	{
		excellent_grade = floor(average * 25);
	}

	if ((excellent_grade > 0) && (excellent_grade >= social))
	{
		cout << "You get a scholarship for excellent results " << excellent_grade << " BGN" << endl;
	}
	else if (social > 0)
	{
		cout << "You get a Social scholarship " << social << " BGN" << endl;
	}
	else
	{
		cout << "You cannot get a scholarship!" << endl;
	}
}