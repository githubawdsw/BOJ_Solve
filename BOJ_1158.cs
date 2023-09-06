// BOJ_1158

using System.Text;

StringBuilder sb = new StringBuilder();
string[] inputnk = Console.ReadLine().Split(' ');
int n = int.Parse(inputnk[0]);
int k = int.Parse(inputnk[1]);
LinkedList<int> ll = new LinkedList<int>();
for (int i = 0; i < n; i++)
    ll.AddLast(i+1);

LinkedListNode<int> ln = ll.First;
sb.Append("<");
while (true)
{
    if (ln.Previous == null && ln.Next == null)
        break;

    for (int i = 0; i < k; i++)
    {
        if (ln != ll.Last)
            ln = ln.Next;
        else
            ln = ll.First;
    }
    if (ln != ll.First)
    {
        sb.Append(ln.Previous.Value);
        ll.Remove(ln.Previous.Value);
    }
    else
    {
        sb.Append(ll.Last.Value);
        ll.Remove(ll.Last.Value);
    }
    sb.Append(", ");

}
sb.Append($"{ll.Last.Value}>");
Console.WriteLine(sb);

