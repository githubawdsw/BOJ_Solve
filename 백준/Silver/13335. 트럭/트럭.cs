// BOJ_13335


int[] inputnwl = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnwl[0];
int w = inputnwl[1];
int l = inputnwl[2];
int[] trcukWeight = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

Queue<(int, int)> q = new Queue<(int, int)>();
int idx = 0;
int time = 0;
int weightOnBridge = 0;
while (idx < n)
{
    time++;
    if(q.Count > 0 && q.Peek().Item2 + w <= time)
    {
        weightOnBridge -= q.Dequeue().Item1;
    }
    if(q.Count == 0 || weightOnBridge + trcukWeight[idx] <= l)
    {
        q.Enqueue((trcukWeight[idx], time));
        weightOnBridge += trcukWeight[idx];
        idx++;
    }
}

Console.WriteLine(time + w);
