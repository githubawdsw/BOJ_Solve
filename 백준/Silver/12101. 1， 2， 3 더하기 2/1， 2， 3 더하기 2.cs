// BOJ_12101


using System.Text;

int[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnk[0];
int k = inputnk[1];
SortedSet<string> ss = new SortedSet<string>();
char[] arr = new char[15];

Dfs(0, 0);
int count = 0;
foreach (var one in ss)
{
    if(count++ == k - 1)
    {
        Console.WriteLine(one);
        return;
    }
}
Console.WriteLine(-1);



void Dfs(int sum, int length)
{
    if(sum == n)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < length; i++)
        {
            sb.Append(arr[i]);
            if(i != length - 1)
                sb.Append('+');
        }
        ss.Add(sb.ToString());
        return;
    }
    else if (sum > n)
        return;

    for (int i = 1; i <= 3; i++)
    {
        arr[length] = (char)(i + '0');
        Dfs(sum + i, length + 1);
    }
}