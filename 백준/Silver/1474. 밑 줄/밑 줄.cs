// BOJ_1474


using System.Text;

StringBuilder sb= new StringBuilder();
int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];


List<string> strList = new List<string>();
bool[] check = new bool[15];
int len = 0;
int lowerCase = 0;
for (int i = 0; i < n; i++)
{
    string str = Console.ReadLine();
	strList.Add(str);

	if (i != 0 && str[0] <= 'Z' )
		check[i - 1] = true;

	if (i != 0 && !check[i - 1])
		lowerCase++;

	len += str.Length;
}

int addUnderLine = (m - len) % (n - 1);
int underLineCount = (m - len) / (n - 1);
if(addUnderLine > lowerCase)
{
	for (int i = n - 1; i >= 0; i--)
	{
		if (check[i])
		{
			check[i] = false;
			lowerCase++;
		}

		if (lowerCase == addUnderLine)
			break;
	}
}

for (int i = 0; i < n; i++)
{
	if(i != 0)
		for (int j = 0; j < underLineCount; j++)
			sb.Append('_');

	sb.Append($"{strList[i]}");
    if (!check[i] && addUnderLine > 0 && i != n - 1)
	{
		sb.Append('_');
		addUnderLine--;
	}
}


Console.WriteLine(sb);