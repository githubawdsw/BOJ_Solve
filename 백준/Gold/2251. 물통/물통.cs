// BOJ_2251


using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputabc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int a = inputabc[0];
int b = inputabc[1];
int c = inputabc[2];

SortedSet<int> ss = new SortedSet<int>();
bool[,,] dir = new bool[205, 205, 205];
bool[] vis = new bool[205];

Dfs(0, 0, c);

foreach (var one in ss)
{
    sb.Append($"{one} ");
}

Console.WriteLine(sb);


void Dfs(int remainA, int remainB, int remainC)
{
    if (dir[remainA, remainB, remainC])
        return;

    dir[remainA, remainB, remainC] = true;
    if(remainA == 0 && !vis[remainC])
    {
        ss.Add(remainC);
        vis[remainC] = true;
    }

    int diffA = a - remainA;
    int diffB = b - remainB;
    int diffC = c - remainC;

    Dfs(Math.Max(0, remainA - diffC), remainB, remainC + Math.Min(remainA, diffC));
    Dfs(Math.Max(0, remainA - diffB), remainB + Math.Min(remainA, diffB), remainC);
    Dfs(remainA, Math.Max(0, remainB - diffC), remainC + Math.Min(remainB, diffC));
    Dfs(remainA + Math.Min(remainB, diffA), Math.Max(0, remainB - diffA), remainC);
    Dfs(remainA + Math.Min(remainC, diffA), remainB, Math.Max(0, remainC - diffA));
    Dfs(remainA, remainB + Math.Min(remainC, diffB), Math.Max(0, remainC - diffB));
}