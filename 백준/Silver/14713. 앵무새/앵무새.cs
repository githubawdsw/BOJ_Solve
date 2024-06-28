// BOJ_14713


int n = int.Parse(Console.ReadLine());
Queue<string>[] q = new Queue<string>[105];
for (int i = 0; i < n; i++)
{
    string[] s = Console.ReadLine().Split(' ');
	q[i] = new Queue<string>();
	for (int j = 0; j < s.Length; j++)
	{
		q[i].Enqueue(s[j]);
	}
}

string[] inputL = Console.ReadLine().Split(' ');
int idx = 0;
while (idx < inputL.Length)
{
	var target = inputL[idx++];
	bool check = false;
	for (int i = 0; i < n; i++)
	{
		if (q[i].Count == 0)
			continue;
		if (q[i].Peek() == target)
		{
			q[i].Dequeue();
			check = true;
		}
	}
	if (!check)
	{
        Console.WriteLine("Impossible");
        return;
	}
}

for (int i = 0; i < n; i++)
{
	if (q[i].Count > 0)
	{
        Console.WriteLine("Impossible");
        return;
	}
}
Console.WriteLine("Possible");