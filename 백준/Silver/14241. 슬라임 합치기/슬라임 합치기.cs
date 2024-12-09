// BOJ_14241


int n = int.Parse(Console.ReadLine());
int[] inputSize = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

Queue<int> q = new Queue<int>();
for (int i = 0; i < n; i++)
{
    q.Enqueue(inputSize[i]);
}

long ans = 0;
while (q.Count > 1)
{
    var cur1 = q.Dequeue();
    var cur2 = q.Dequeue();

    q.Enqueue(cur1 + cur2);
    ans += cur1 * cur2;
}

Console.WriteLine(ans);