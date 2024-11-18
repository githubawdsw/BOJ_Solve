// BOJ_5464


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

Dictionary<int,int> posDict = new Dictionary<int,int>();
for (int i = 0; i < n; i++)
{
    posDict.Add(i, int.Parse(Console.ReadLine()));
}

Dictionary<int, int> weightDict = new Dictionary<int, int>();
for (int i = 1; i <= m; i++)
{
    weightDict.Add(i, int.Parse(Console.ReadLine()));
}

SortedSet<int> line = new SortedSet<int>();
int[] used = new int[2005];
Queue<int> wait = new Queue<int>();
for (int i = 0; i < n; i++)
{
    line.Add(i);
}

int ans = 0;
for (int i = 0; i < 2 * m; i++)
{
    int number = int.Parse(Console.ReadLine());
    if(number > 0)
    {
        wait.Enqueue(number);
        if(line.Count == 0)
        {
            continue;
        }

        var target = wait.Dequeue();
        int pos = line.First();

        line.Remove(pos);
        used[target] = pos;
        ans += posDict[pos] * weightDict[target];
    }
    else
    {
        number *= -1;
        line.Add(used[number]);

        if(wait.Count > 0 && line.Count > 0)
        {
            var target = wait.Dequeue();
            int pos = line.First();

            line.Remove(pos);
            used[target] = pos;
            ans += posDict[pos] * weightDict[target];
        }
    }
}

Console.WriteLine(ans);