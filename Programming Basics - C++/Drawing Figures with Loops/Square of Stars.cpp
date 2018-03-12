#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

int main() {
	int n; cin >> n;
    
	for (size_t r = 1; r <= n; r++)
	{
		cout << "*";
		for (size_t c = 1; c < n; c++)
			cout << " *";
		cout << endl;
	}
}