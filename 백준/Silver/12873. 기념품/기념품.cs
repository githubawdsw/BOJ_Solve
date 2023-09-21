// BOJ_12873



int n = int.Parse(Console.ReadLine());
Queue<double> q = new Queue<double>();

for (int i = 0; i < n; i++)
    q.Enqueue(i + 1);

for (int i = 1; i < n; i++)
{
    int val = i;
    double t = Math.Pow(val, 3);
    double pos = t % q.Count;
    if (pos == 0)
        pos = q.Count;
    double count = 1;

    while (q.Count > 1)
    {
        double cur = q.Dequeue();
        if (count == pos)
            break;
        count++;
        q.Enqueue(cur);
    }
}
Console.WriteLine(  q.Peek());
