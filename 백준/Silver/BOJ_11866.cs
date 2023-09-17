// BOJ_11866


using System.Text;

List<int> list = new List<int>();

string[] input = Console.ReadLine().Split(' ');
int n = int.Parse(input[0]);
int k = int.Parse(input[1]);

for (int i = 1; i <= n; i++)
    list.Add(i);

StringBuilder sb = new StringBuilder();
sb.Append("<");
int idx = k-1;
while (list.Count != 0)
{
    while (idx >= n)
        idx -= n;
        
    if(list.Count != 1)
        sb.Append($"{list[idx]}, ");
    else
        sb.Append($"{list[idx]}>");
    list.RemoveAt(idx);

    idx += k - 1;
    n--;
}

Console.WriteLine(  sb);
