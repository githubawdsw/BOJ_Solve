// BOJ_14225


int n = int.Parse(Console.ReadLine());
int[] inputArrInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

List<int> list = new List<int>();
SortedSet<int> ss = new SortedSet<int>();
bool[] vis = new bool[25];
Dfs(0);

void Dfs(int idx)
{
    ss.Add(list.Sum());

    for (int i = idx; i < n; i++)
    {
        if (vis[i])
            continue;

        list.Add(inputArrInfo[i]);
        vis[i] = true;
        Dfs(i);

        list.Remove(inputArrInfo[i]);
        vis[i] = false;
    }
}

int ans = 0;
int value = 0;
foreach (var one in ss)
{
    if (one != value)
    {
        ans = value;
        break;
    }
    value++;
}

if (ans == 0)
    Console.WriteLine(ss.Last() + 1);
else
    Console.WriteLine(ans);