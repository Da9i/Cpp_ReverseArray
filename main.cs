#include<iostream>
using namespace std;
int main()
{
	char arr[100], start, end;
	int i = 0, j = 0, vowel = 0;;
	cout << "ENTER STRING:";
	cin.getline(arr, 100);
	cout << "ENTER STARTING POINT OF STRING:";
	cin >> start;
	cout << "ENTER ENDING POINT OF STRING:";
	cin >> end;
	while (true)
	{
		if (arr[i] != start)
			i++;
		if (arr[j] != end)
			j++;
		if (arr[i] == start && arr[j] == end)
			break;
	}
	while (true)
	{
		char temp = arr[i];
		arr[i] = arr[j];
		arr[j] = temp;
		i++;
		j--;
		if (i > j)
			break;
	}
	cout << arr << endl;
	system("pause>0");
}
