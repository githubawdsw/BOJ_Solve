// BOJ_17471



int n = int.Parse(Console.ReadLine());
int[] inputPopulation = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();

for (int i = 1; i <= n; i++)
{
    int[] inputRel = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    dict.Add(i, new List<int>());
    for (int j = 1; j <= inputRel[0]; j++)
    {
        dict[i].Add(inputRel[j]);
    }
}

int min = int.MaxValue;
List<int> groupA = new List<int>();
List<int> groupB = new List<int>();
Dfs(1);

if(min == int.MaxValue)
    Console.WriteLine(-1);
else
    Console.WriteLine(min);


void Dfs(int depth)
{
    if(depth > n)
    {
        int sumA = 0;
        int sumB = 0;
        if(IsConnected(groupA) && IsConnected(groupB))
        {
            for (int i = 0; i < groupA.Count; i++)
            {
                sumA += inputPopulation[groupA[i] - 1];
            }
            for (int i = 0; i < groupB.Count; i++)
            {
                sumB += inputPopulation[groupB[i] - 1];
            }
            min = Math.Min(min, Math.Abs(sumA - sumB));
        }
        return;
    }

    groupA.Add(depth);
    Dfs(depth + 1);
    groupA.RemoveAt(groupA.Count - 1);

    groupB.Add(depth);
    Dfs(depth + 1);
    groupB.RemoveAt(groupB.Count - 1);
}

bool IsConnected(List<int> list)
{
    if (list.Count == 0)
        return false;

    list.Sort();
    Queue<int> q = new Queue<int>();
    q.Enqueue(list[0]);
    HashSet<int> vis = q.ToHashSet();

    while (q.Count > 0)
    {
        var cur = q.Dequeue();
        foreach (var one in dict[cur])
        {
            if (!vis.Contains(one) && list.Contains(one))
            {
                vis.Add(one);
                q.Enqueue(one);
            }
        }
    }

    bool check = true;
    for (int i = 0; i < list.Count; i++)
    {
        if (!vis.Contains(list[i]))
        {
            check = false;
            break;
        }
    }
    return check;
}