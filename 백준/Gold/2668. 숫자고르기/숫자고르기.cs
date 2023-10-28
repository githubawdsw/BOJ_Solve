// BOJ_2668



using System.Text;

StringBuilder sb = new StringBuilder();

List<int>[] arrList = new List<int>[105];
bool[] vis;
List<int> ansList = new List<int>();
bool check;

int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    int val = int.Parse(Console.ReadLine());
    if (arrList[i] == null)
        arrList[i] = new List<int>();
    arrList[i].Add(val);
}

for (int i = 1; i <= n; i++)
{
    check = false;
    vis = new bool[2005];
    vis[i] = true;
    dfs(i , 0 , 0);
    if (check)
    {
        for (int j = 1; j <= n; j++)
        {
            if (vis[i] && !ansList.Contains(i))
                ansList.Add(i);
        }
    }
}

sb.AppendLine(ansList.Count.ToString());
for (int i = 0; i < ansList.Count; i++)
    sb.AppendLine(ansList[i].ToString());

Console.WriteLine(  sb);


void dfs(int start , int idx , int count)
{
    if (idx == 0)
        idx = start;
    if (arrList[idx] == null)
        return;

    foreach (var one in arrList[idx])
    {
        if (vis[one])
        {
            if(start == one)
                check = true;
            continue;
        }
        vis[one] = true;
        dfs(start, one, count + 1);
    }
}