// BOJ_1254


string str = Console.ReadLine();

int ans = str.Length;
if (ans == 1)
{
    Console.WriteLine(1);
    return;
}
for (int i = str.Length / 2; i < str.Length; i++)
{
    bool check1 = false, check2 = false;
	for (int j = 0; i + j < str.Length; j++)
	{
		if (str[i + j] != str[i - j])
        {
            check1 = true;
			break;
        }
	}

    for (int j = 0; i + j < str.Length ; j++)
    {
        if (i - j - 1 < 0 || str[i + j] != str[i - j - 1])
        {
            check2 = true;
            break;
        }
    }


    if (!check1 || !check2) 
    {
        if (!check2)
        {
            ans += 2 * i - str.Length;
        }
        else
        {
            ans += 2 * i - str.Length + 1;
        }
        break;
    }
    if (i == str.Length - 1 && (check1 && check2))
        ans += str.Length - 1;
}

Console.WriteLine(ans);