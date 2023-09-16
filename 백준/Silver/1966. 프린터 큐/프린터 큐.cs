// BOJ_1966


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());

while (t-- > 0)
{
    string[] inputnm = Console.ReadLine().Split(' ');
    int n = int.Parse(inputnm[0]);
    int m = int.Parse(inputnm[1]);

    Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();
    List<int> importanceList = new List<int>();
    string[] inputarr = Console.ReadLine().Split(' ');
    for (int i = 0; i < n; i++)
    {
        q.Enqueue(new Tuple<int, int>( int.Parse(inputarr[i]) , i));
        importanceList.Add(int.Parse(inputarr[i]));
    }

    importanceList = importanceList.OrderByDescending(x => x).ToList();
    int idx = 0;
    int count = 0;
    while (q.Count > 0)
    {
        var cur = q.Dequeue();
        if (cur.Item1 != importanceList[idx])
        {
            q.Enqueue(cur);
            continue;
        }

        count++;
        idx++;
        if(cur.Item2 == m)
        {
            sb.AppendLine(count.ToString());
            break;
        }
    }
}
Console.WriteLine(  sb);