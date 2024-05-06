// BOJ_18115


using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
int[] inputA = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

LinkedList<int> ll = new LinkedList<int>();
LinkedListNode<int> node = ll.First;
for (int i = n - 1; i >= 0; i--)
{
    int number = n - i;
    if (inputA[i] == 1)
    {
        ll.AddFirst(number);
    }
    else if (inputA[i] == 2)
    {
        node = ll.First;
        ll.AddAfter(node, number);
        node = node.Next;
    }
    else
    {
        ll.AddLast(number);
    }
}

foreach(var one in ll)
{
    sb.Append($"{one} ");
}

Console.WriteLine(sb);

