// BOJ_16139


using System.Text;

StringBuilder sb = new StringBuilder();
string inputstr = Console.ReadLine();
int q = int.Parse(Console.ReadLine());
int[,] dp = new int[200005, 30];
for (int i = 0; i < inputstr.Length; i++)
{
    if(i != 0)
        for (int j = 0; j < 26; j++)
        {
            dp[i, j] = dp[i - 1, j];
        }
    int now = inputstr[i] - 'a';
    dp[i, now]++;
}

for (int i = 0; i < q; i++)
{
    string[] inputarr = Console.ReadLine().Split(' ');
    char a = Convert.ToChar( inputarr[0]);
    int l = int.Parse(inputarr[1]);
    int r = int.Parse(inputarr[2]);
    int target = a - 'a';
    if( l == 0)
        sb.AppendLine($"{dp[r, target]}");
    else
        sb.AppendLine($"{dp[r, target] - dp[l - 1, target]}");
}

Console.WriteLine(  sb);

