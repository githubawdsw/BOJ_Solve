// BOJ_21314


string str = Console.ReadLine();

int count = 0;
string max = "";
for (int i = 0; i < str.Length; i++)
{
	if (str[i] == 'M')
	{
		count++;
	}
	else if (str[i] == 'K')
	{
		max += '5';
		for (int j = 0; j < count; j++)
		{
			max += '0';
		}
		count = 0;
	}
}
while (count-- > 0)
{
	max += '1';
}

count = 0;
string min = "";
for (int i = 0; i < str.Length; i++)
{
    if (str[i] == 'M')
    {
        count++;
    }
    else if (str[i] == 'K')
    {
		if(count > 0)
			min += '1';
        for (int j = 0; j < count - 1; j++)
        {
            min += '0';
        }
		min += '5';
        count = 0;
    }
}
if(count-- > 0)
{
	min += '1';
	while (count-- > 0)
	{
		min += '0';
	}

}

Console.WriteLine(max);
Console.WriteLine(min);