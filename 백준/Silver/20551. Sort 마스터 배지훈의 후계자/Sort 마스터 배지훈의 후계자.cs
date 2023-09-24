// BOJ_20551


using System.Text;

StringBuilder sb = new StringBuilder();
string[] inputnm = Console.ReadLine().Split(' ');
int n = int.Parse(inputnm[0]);
int m =  int.Parse(inputnm[1]);

List<int> list = new List<int>();
Dictionary<int, int> dict = new Dictionary<int, int>();
for (int i = 0; i < n; i++)
    list.Add( int.Parse(Console.ReadLine()));

list.Sort();
for (int i = 0; i < n; i++)
{
    if (!dict.ContainsKey(list[i]))
        dict.Add(list[i], i);
}

for (int i = 0; i < m; i++)
{
    int question = int.Parse(Console.ReadLine());
    if (!dict.ContainsKey(question))
        sb.AppendLine("-1");
    
    else
        sb.AppendLine(dict[question].ToString());
}
Console.WriteLine(  sb );
