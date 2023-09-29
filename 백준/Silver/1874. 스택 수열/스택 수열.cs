// BOJ_1874

using System.Text;

Stack<int> s = new Stack<int>();
StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
int idx = 1;
for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    while (true)
    {
        if(s.Count != 0 && num == s.Peek())
        {
            s.Pop();
            sb.AppendLine("-");
            break;
        }
        else
        {
            sb.AppendLine("+");
            s.Push(idx);
            idx++;
        }
        if(idx > n + 1)
        {
            Console.WriteLine(  "NO");
            return;
        }
    }
}
Console.WriteLine(  sb);