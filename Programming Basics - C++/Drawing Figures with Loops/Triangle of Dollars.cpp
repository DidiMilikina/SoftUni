#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

int main() {
	int n; cin >> n;
    
	for (size_t row = 1; row <= n; row++)
	{
		cout << "$";
		for (size_t col = 1; col < row; col++)
		{
			cout << " $";
		}
		cout << endl;
	}
}