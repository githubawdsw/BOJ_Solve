// BOJ_17298

using System.Text;

int n = int.Parse(Console.ReadLine());

string[] inputarr = Console.ReadLine().Split(' ');
Stack<int> s = new Stack<int>();
int[] ans = new int[n + 2];
for (int i = n-1; i >= 0; i--)
{
    while (s.Count != 0 && s.Peek() <= int.Parse(inputarr[i]))
        s.Pop();
    if (s.Count == 0)
        ans[i] = -1;
    else
        ans[i] = s.Peek();
    s.Push(int.Parse(inputarr[i]));
}
StringBuilder sb = new StringBuilder();
for (int i = 0; i < n; i++)
    sb.Append($"{ans[i]} ");

Console.WriteLine(  sb);



