// BOJ_2479


int[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnk[0];
int k = inputnk[1];

List<string> list = new List<string>();
for (int i = 0; i < n; i++)
{
    string inputBinary = Console.ReadLine();
    list.Add(inputBinary);
}

int[] inputse = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int s = inputse[0];
int e = inputse[1];

Queue<(string, string, int)> q = new Queue<(string, string, int)>();
bool[] vis = new bool[1005];
q.Enqueue((list[s - 1], s.ToString(), s - 1));
vis[s - 1] = true;
while (q.Count > 0)
{
    var cur = q.Dequeue();
    for (int i = 0; i < list.Count; i++)
    {
        if (vis[i])
            continue;

        int count = 0;
        for (int j = 0; j < list[i].Length; j++)
        {
            if (list[i][j] != cur.Item1[j])
                count++;
            if (count > 1)
                break;
        }

        if(count == 1)
        {
            if(i == e - 1)
            {
                Console.WriteLine(cur.Item2 + " " + (i + 1).ToString());
                return;
            }

            q.Enqueue((list[i], cur.Item2 + " " + (i + 1).ToString(), i));
            vis[i] = true;
        }
    }
}

Console.WriteLine(-1);