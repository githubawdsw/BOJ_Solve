// BOJ_22233


using System.Text;

StringBuilder sb= new StringBuilder();
int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

HashSet<string> hs = new HashSet<string>();
for (int i = 0; i < n; i++)
{
    hs.Add(Console.ReadLine());
}

for (int i = 0; i < m; i++)
{
    string[] delete = Console.ReadLine().Split(',');
    for (int j = 0; j < delete.Length; j++)
    {
        hs.Remove(delete[j]);
    }
    sb.AppendLine(hs.Count.ToString());
}

Console.WriteLine(sb);