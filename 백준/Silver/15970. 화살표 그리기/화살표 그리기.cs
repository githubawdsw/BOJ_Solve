// BOJ_15970


int n = int.Parse(Console.ReadLine());

Dictionary<int,List<int>> dict = new Dictionary<int,List<int>>();
for (int i = 0; i < n; i++)
{
    int[] inputxy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    if (!dict.ContainsKey(inputxy[1]))
        dict.Add(inputxy[1], new List<int>());
    dict[inputxy[1]].Add(inputxy[0]);
}

int sum = 0;
foreach (var one in dict)
{
    one.Value.Sort();
    int before = one.Value[1] - one.Value[0];
    sum += before;
    for (int i = 2; i < one.Value.Count; i++)
    {
        int val = one.Value[i] - one.Value[i-1];
        if (before > val)
            sum += val;
        else
            sum += before;

        before = val;
    }
    sum += before;
}

Console.WriteLine(sum);
