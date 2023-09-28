// BOJ_24511



using System.Text;

int n = int.Parse(Console.ReadLine());
string[] inputqs = Console.ReadLine().Split(' ');
string[] contents = Console.ReadLine().Split(" ");
Queue<int> q = new Queue<int>();
for (int i = n-1; i >= 0; i--)
{
    if (inputqs[i] == "0")
        q.Enqueue(int.Parse(contents[i]));
}

StringBuilder sb = new StringBuilder();
int m =  int.Parse(Console.ReadLine());
string[] carr = Console.ReadLine().Split(" ");
for (int i = 0; i < m; i++)
{
    q.Enqueue(int.Parse(carr[i]));
    sb.Append($"{q.Dequeue()} ");
}

Console.WriteLine(  sb);

