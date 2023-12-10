// BOJ_17952


int n = int.Parse(Console.ReadLine());

Stack<(int,int)> s = new Stack<(int,int)>();
int ans = 0;
for (int i = 0; i < n; i++)
{
    int[] inputinfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    if (inputinfo[0] == 0)
    {
        if(s.Count  > 0)
        {
            var pop = s.Pop();
            if (pop.Item2 - 1 == 0)
                ans += pop.Item1;
            else
                s.Push(new(pop.Item1, pop.Item2 - 1));
        }
        continue;
    }
    int a = inputinfo[1];
    int t = inputinfo[2];
    if(t - 1 == 0)
    {
        ans += a;
        continue;
    }
    s.Push(new(a, t - 1));
}

Console.WriteLine(ans);