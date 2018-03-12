#include <iostream>
#include <string>

using namespace std;

int main()
{
	int n;
	cin >> n;

	int width = 3 * n + 6;
	int height = 3 * n + 1;

	for (int i = 0; i < n; ++i)
	{
		cout << string(n, ' ') << '~' << ' ' << '~' << ' ' << '~' << endl;
	}

	cout << string(width - 1, '=') << endl;

	for (int i = 0; i < n - 2; ++i)
	{
		if (n / 2 != i + 1)
		{
			cout << "|" << string(2 * n + 4, '~') << "|" << string(n - 1, ' ') << "|" << string(n - 1, ' ') << endl;
		}
		else
		{
			cout << "|" << string(n, '~') << "JAVA" << string(n, '~') << "|" << string(n - 1, ' ') << "|" << endl;
		}
	}

	cout << string(width - 1, '=') << endl;

	int a = 2 * n + 4;
	for (int i = 0; i < n; ++i)
	{
		cout << string(i, ' ') << "\\" << string(a, '@') << "/" << endl;
		a -= 2;
	}

	cout << string(2 * n + 6, '=') << endl;

	return 0;
}