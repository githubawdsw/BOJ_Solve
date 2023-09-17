// BOJ_10809


using System.Text;

string s = Console.ReadLine();

StringBuilder sb = new StringBuilder();
for (int i = 0; i < 26; i++)
{
    char c = (char)(i + 97);
	bool check = false;
	int idx = 0;
	for (int j = 0; j < s.Length; j++)
	{
		if (s[j] == c)
		{
			check = true;
			idx = j;
			break;
		}
	}
	if (check)
		sb.Append($"{idx} ");
	else
		sb.Append($"-1 ");
}
Console.WriteLine(	sb);

