// BOJ_1021
  

string[] inputnm = Console.ReadLine().Split(' ');
int n = int.Parse(inputnm[0]);
int m = int.Parse(inputnm[1]);
string[] inputarr = Console.ReadLine().Split(' ');
LinkedList<int> ll = new LinkedList<int>();
for (int i = 1; i <= n; i++)
    ll.AddLast(i);
LinkedListNode<int> ln = ll.First;

int count = 0;
for (int i = 0; i < m; i++)
{
    int target = int.Parse(inputarr[i]);
    int[] toarr = new int[55];
    ll.CopyTo(toarr, 0);
    int idx = Array.IndexOf(toarr, target);
    while (target != ll.First.Value)
    {
        if(idx <= ll.Count / 2)
        {
            ll.AddLast(ll.First.Value);
            ll.Remove(ll.First);
            count++;
        }
        else
        {
            ll.AddFirst(ll.Last.Value);
            ll.Remove(ll.Last);
            count++;
        }
    }
    ll.Remove(ll.First);
}

Console.WriteLine(count);