// BOJ_9019



using System.Text;

StringBuilder sb = new StringBuilder();
char[] d = { 'D', 'S', 'L', 'R' };
Queue<(int, string)> q = new Queue<(int, string)>();
int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int[] inputab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int a = inputab[0];
    int b = inputab[1];

    bool[] vis = new bool[10005];
    q.Enqueue((a, ""));
    while (q.Count > 0)
    {
        var cur = q.Dequeue();
        int convert = 0;
        for (int i = 0; i < 4; i++)
        {
            if(d[i] == 'D')
            {
                convert = (cur.Item1 * 2) % 10000;

                if (vis[convert])
                    continue;
                vis[convert] = true;

                q.Enqueue((convert , cur.Item2 + "D"));
                if (convert == b)
                {
                    sb.AppendLine(cur.Item2 + 'D');
                    q.Clear();
                    break;
                }
            }
            else if (d[i] == 'S')
            {
                convert = cur.Item1 - 1;
                if (convert < 0)
                    convert = 9999;

                if (vis[convert])
                    continue;
                vis[convert] = true;

                q.Enqueue((convert, cur.Item2 + "S"));
                if (convert == b)
                {
                    sb.AppendLine(cur.Item2 + 'S');
                    q.Clear();
                    break;
                }
            }
            else if (d[i] == 'L')
            {
                convert = ((cur.Item1 % 1000) * 10) + (cur.Item1 / 1000);

                if (vis[convert])
                    continue;
                vis[convert] = true;

                q.Enqueue((convert, cur.Item2 + "L"));
                if (convert == b)
                {
                    sb.AppendLine(cur.Item2 + 'L');
                    q.Clear();
                    break;
                }
            }
            else if (d[i] == 'R')
            {
                convert = ((cur.Item1 % 10) * 1000) + (cur.Item1 / 10);

                if (vis[convert])
                    continue;
                vis[convert] = true;

                q.Enqueue((convert, cur.Item2 + "R"));
                if (convert == b)
                {
                    sb.AppendLine(cur.Item2 + 'R');
                    q.Clear();
                    break;
                }
            }
        }
    }
}

Console.WriteLine(sb);
