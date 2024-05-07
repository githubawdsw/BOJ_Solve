// BOJ_19638


int[] inputnht = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnht[0];
int h = inputnht[1];
int t = inputnht[2];

PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
int count = 0;

for (int i = 0; i < n; i++)
{
    int height = int.Parse(Console.ReadLine());
    pq.Enqueue(-height, -height);
}

while (count < t && -pq.Peek() >= h && -pq.Peek() != 1)
{
    var cur = -pq.Dequeue();
    pq.Enqueue(-(cur / 2), -(cur / 2));
    count++;
}

if(-pq.Peek() < h)
{
    Console.WriteLine("YES");
    Console.WriteLine(count);
}
else
{
    Console.WriteLine("NO");
    Console.WriteLine(-pq.Peek());
}
