// BOJ_3078


int[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnk[0];
int k = inputnk[1];

List<string> list = new List<string>();
for (int i = 0; i < n; i++)
{
    list.Add(Console.ReadLine());
}

long ans = 0;
Queue<int>[] q = new Queue<int>[23];
for (int i = 1; i <= n; i++)
{
    int len = list[i - 1].Length;

    if (q[len] == null)
        q[len] = new Queue<int>();

    while (q[len].Count > 0 && i - q[len].First() > k)
    {
        q[len].Dequeue();
    }
    ans += q[len].Count;
    q[len].Enqueue(i);
}

Console.WriteLine(ans);