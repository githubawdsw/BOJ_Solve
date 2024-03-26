// BOJ_20006


using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputpm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int p = inputpm[0];
int m = inputpm[1];

List<(int, string)>[] list = new List<(int, string)>[305];
for (int i = 0; i < p; i++)
{
    string[] inputln = Console.ReadLine().Split(" ");
    int l = int.Parse(inputln[0]);
    string n = inputln[1];

    for (int j = 0; j < list.Length; j++)
    {
        if (list[j] == null)
            list[j] = new List<(int, string)>();
        if (list[j].Count == 0)
        {
            list[j].Add((l, n));
            break;
        }
        else
        {
            if (list[j].Count == m)
                continue;
            if (l >= list[j][0].Item1 - 10 && l <= list[j][0].Item1 + 10)
            {
                list[j].Add((l, n));
                break;
            }
        }
    }
}

for(int i = 0; i < list.Length; i++)
{
    if (list[i] == null)
        break;

    list[i] = list[i].OrderBy(x => x.Item2).ToList();

    if (list[i].Count < m)
        sb.AppendLine("Waiting!");
    else
        sb.AppendLine("Started!");

    for (int j = 0; j < list[i].Count; j++)
    {
        sb.AppendLine($"{list[i][j].Item1} {list[i][j].Item2}");
    }
}

Console.WriteLine(sb);