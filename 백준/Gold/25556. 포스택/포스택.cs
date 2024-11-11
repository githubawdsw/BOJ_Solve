// BOJ_25556


int n = int.Parse(Console.ReadLine());
int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

List<int> list = new List<int>();
List<Stack<int>> sList = new List<Stack<int>>();
for (int i = 0; i < 4; i++)
{
    sList.Add(new Stack<int>());
}

for (int i = 0; i < inputArr.Length; i++)
{
	int target = inputArr[i];
	foreach (var one in sList)
	{
		if(one.Count == 0 || one.Peek() < target)
		{
			one.Push(target);
			break;
		}
	}
}

for (int i = n; i >= 1; i--)
{
	bool check = false;
	foreach (var one in sList)
	{
		if(one.Count > 0 && i == one.Peek())
		{
			one.Pop();
			list.Add(i);
			check = true;
			break;
		}
	}
	if (!check)
	{
        Console.WriteLine("NO");
        return;
	}
}

Console.WriteLine("YES");