// BOJ_2161



int n = int.Parse(Console.ReadLine());

Queue<int> q = new Queue<int>();
for (int i = 0; i < n; i++)
    q.Enqueue(i + 1);

string ans = "";
while (q.Count != 1)
{
    ans += q.Dequeue().ToString() + " ";
    q.Enqueue(q.Dequeue());
}
ans += q.Peek().ToString();
Console.WriteLine(ans);
