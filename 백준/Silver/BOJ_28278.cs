// BOJ_28278



using System.Text;

int n =int.Parse(Console.ReadLine());
Stack<int> s = new Stack<int>();
StringBuilder sb = new StringBuilder();
while (n-- > 0)
{
    string[] input = Console.ReadLine().Split(' ');
    if (input[0] == "1")
        s.Push(int.Parse(input[1]));

    else if (input[0] == "2")
    {
        if (s.Count > 0)
            sb.AppendLine(s.Pop().ToString());
        else
            sb.AppendLine("-1");
    }

    else if (input[0] == "3")
        sb.AppendLine(s.Count.ToString());

    else if (input[0] == "4")
    {
        if (s.Count > 0)
            sb.AppendLine("0");
        else
            sb.AppendLine("1");
    }

    else if (input[0] == "5")
    {
        if(s.Count > 0)
            sb.AppendLine(s.Peek().ToString());
        else 
            sb.AppendLine("-1");
    }
}
Console.WriteLine(  sb);

