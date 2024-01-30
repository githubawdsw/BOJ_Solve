// BOJ_16937


using System.Text;

StringBuilder sb = new StringBuilder();

int n = int.Parse(Console.ReadLine());
long[] inputArrB = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

Dictionary<long, long> dict = new Dictionary<long, long>();
long node = 0;

for (int i = 0; i < n; i++)
{
    var cur = inputArrB[i];
    if ( Array.IndexOf(inputArrB, cur * 3) != -1)
    {
        dict[cur * 3] = cur;
        continue;
    }
    else if (cur % 2 == 0 && Array.IndexOf(inputArrB, cur / 2) != -1)
    {
        dict[cur / 2] = cur;
        continue;
    }

    node = cur;
}

sb.Append($"{node} ");
for (int i = 0; i < n - 1; i++)
{
    sb.Append($"{dict[node]} ");
    node = dict[node];
}

Console.WriteLine(sb);