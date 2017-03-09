#include<iostream>
using namespace std;
int main()
{
	int i, j, n;
	cout << "Enter the number of lines";
	cin >> n;
	for (i = 0; i < n; i++)
	{
		for ( j = 0; j < i; j++)
		{
			cout << "*\t";
		}
		cout << endl;
	}
	return 0;
}