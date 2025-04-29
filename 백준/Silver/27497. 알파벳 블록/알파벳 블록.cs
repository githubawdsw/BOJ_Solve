// BOJ_27497


using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());

LinkedList<string> ll = new LinkedList<string>();
Stack<bool> s = new Stack<bool>();
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    if (input[0] == "1")
    {
        ll.AddLast(input[1]);
        s.Push(false);
    }
    else if (input[0] == "2")
    {
        ll.AddFirst(input[1]);
        s.Push(true);
    }
    else
    {
        if (s.Count == 0)
            continue;

        var cur = s.Pop();
        if (cur)
            ll.RemoveFirst();
        else
            ll.RemoveLast();
    }

}

foreach (var one in ll)
{
    sb.Append(one);
}

if (ll.Count == 0)
    sb.Append(0);

Console.WriteLine(sb);