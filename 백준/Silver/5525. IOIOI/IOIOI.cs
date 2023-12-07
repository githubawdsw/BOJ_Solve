// BOJ_5525


int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
string inputarr = Console.ReadLine();

string baseString = "I";
for (int i = 0; i < n; i++)
    baseString += "OI";

int ans = 0;
bool check;
for (int i = 0; i <= m - baseString.Length; i++)
{
	if (inputarr[i] == 'O')
		continue;
	check = true;
	for (int j = 0; j < baseString.Length; j++)
	{
		if (baseString[j] != inputarr[i + j])
		{
			check = false;
			break;
		}
	}
	if (check)
		ans++;
}

Console.WriteLine(ans);