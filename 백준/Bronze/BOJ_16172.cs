//  BOJ_16172


string s = Console.ReadLine();

string k = Console.ReadLine();
int[] f = failureFuc(k);

int j = 0;
for (int i = 0; i < s.Length; i++)
{
	if (s[i] >= '0' && s[i] <= '9')
		continue;
	while (j > 0 && s[i] != k[j])
		j = f[j - 1];
	if (s[i] == k[j])
		j++;
	if(j == k.Length)
	{
        Console.WriteLine(	1);
        return;
	}
}
Console.WriteLine(	0);


int[] failureFuc(string str)
{
	int[] failure = new int[str.Length];
	int j = 0;
	for (int i = 1; i < str.Length; i++)
	{
		while (j > 0 && str[i] != str[j])
			j = failure[j - 1];
		if (str[i] == str[j])
			failure[i] = ++j;
	}
	return failure;
}
