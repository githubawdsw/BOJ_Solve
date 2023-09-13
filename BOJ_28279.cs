// BOJ_28279


using System.Text;

LinkedList<int> ll  = new LinkedList<int>();
LinkedListNode<int> lln = ll.Last;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    switch (int.Parse(input[0]))
    {
        case 1:
            ll.AddFirst(int.Parse(input[1]));
            break;

        case 2:
            ll.AddLast(int.Parse(input[1]));
            break;

        case 3:
            if (ll.Count > 0)
            {
                sb.AppendLine(ll.First.Value.ToString());
                ll.RemoveFirst();
            }
            else
                sb.AppendLine("-1");
            break;
        
        case 4:
            if(ll.Count > 0)
            {
                sb.AppendLine(ll.Last.Value.ToString());
                ll.RemoveLast();
            }
            else
                sb.AppendLine("-1");
            break;

        case 5:
            sb.AppendLine(ll.Count.ToString());
            break;

        case 6:
            if (ll.Count == 0)
                sb.AppendLine("1");
            else
                sb.AppendLine("0");
            break;

        case 7:
            if (ll.Count > 0)
                sb.AppendLine(ll.First.Value.ToString());
            else
                sb.AppendLine("-1");
            break;

        case 8:
            if (ll.Count > 0)
                sb.AppendLine(ll.Last.Value.ToString());
            else
                sb.AppendLine("-1");
            break;

        default:
            break;
    }

}
Console.WriteLine(  sb);
