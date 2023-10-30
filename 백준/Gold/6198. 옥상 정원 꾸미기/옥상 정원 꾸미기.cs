// BOJ_6198


using System.IO.Pipes;
using System.Text;

int n = int.Parse(Console.ReadLine());

Stack<long> s = new Stack<long>();
long h;
long ans = 0;

for (int i = 0; i < n; i++)
{
    h = int.Parse(Console.ReadLine());
    while (s.Count != 0 && s.Peek() <= h)
        s.Pop();
    ans += s.Count;
    s.Push(h);
}
Console.WriteLine(  ans);

