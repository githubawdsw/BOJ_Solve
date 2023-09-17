// BOJ_2164
    


StreamReader sr = new StreamReader(Console.OpenStandardInput());

int n = int.Parse(sr.ReadLine());
Queue<int> q = new Queue<int>();
for (int i = 1; i <= n; i++)
    q.Enqueue(i);
for (int i = 1; q.Count != 1; i++)
{
    if (i % 2 == 1)
        q.Dequeue();
    else
        q.Enqueue(q.Dequeue());
}
Console.WriteLine(q.Peek());