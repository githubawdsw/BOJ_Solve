// BOJ_10773

Stack<int> s = new Stack<int>();
int k = int.Parse(Console.ReadLine());
for (int i = 0; i < k; i++)
{
    int n = int.Parse(Console.ReadLine());
    if (n == 0)
        s.Pop();
    else
        s.Push(n);
}

int ans = 0;
while (s.Count > 0)
    ans += s.Pop();

Console.WriteLine(ans);
