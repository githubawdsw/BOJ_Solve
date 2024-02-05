// BOJ_17503


long[] inputnmk = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
long n = inputnmk[0];
long m = inputnmk[1];
int k = (int)inputnmk[2];

List<(int, int)> list = new List<(int, int)>();
for (int i = 0; i < k; i++)
{
    int[] inputvc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int v = inputvc[0];
    int c = inputvc[1];
    list.Add((c, v));
}

list.Sort();
PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
long sum = 0;
for (int i = 0; i < k; i++)
{
    pq.Enqueue(list[i].Item2, list[i].Item2);
    sum += list[i].Item2;
    if(pq.Count > n)
        sum -= pq.Dequeue();
    if(pq.Count == n && sum >= m)
    {
        Console.WriteLine(list[i].Item1);
        return;
    }
}

Console.WriteLine(-1);