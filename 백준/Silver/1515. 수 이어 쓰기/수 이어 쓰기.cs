// BOJ_1515


string input = Console.ReadLine();

int idx = 0;
int length = input.Length;
int num = 1;
while (idx < length)
{
    string target = num.ToString();
	for (int i = 0; i < target.Length; i++)
	{
		if (idx < length && target[i] == input[idx])
			idx++;
	}
	num++;
}

Console.WriteLine(num - 1);