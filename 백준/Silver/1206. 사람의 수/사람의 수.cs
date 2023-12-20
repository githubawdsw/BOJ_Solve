// BOJ_1206



int n = int.Parse(Console.ReadLine());

List<string> list = new List<string>();
for (int i = 0; i < n; i++)
    list.Add(Console.ReadLine());


for (int i = 1; i <= 1000000; i++)
{
	bool check = true;
    for (int j = 0; j < list.Count; j++)
	{
		var cur = int.Parse(list[j].Replace("." , ""));
		int value = cur * i;
		float valueF = value;
		if(valueF / 1000 == (int)(valueF / 1000))
		{
			if ((value / i) != cur)
			{
				check = false;
				break;
			}
		}
		else
		{
			if (((value + 1000) / 1000 * 1000 / i) != cur)
			{
                check = false;
				break;
			}
		}
	}
	if (check)
	{
        Console.WriteLine(i);
        return;
	}
}