// BOJ_17390

using System.Text;

string[] inputnq = Console.ReadLine().Split(' ');
int n = int.Parse(inputnq[0]);
int q = int.Parse(inputnq[1]);
string[] inputAn = Console.ReadLine().Split(" ");

List<int> arrList = new List<int>();
int[] dp = new int[300005];
StringBuilder sb = new StringBuilder();

for (int i = 0; i < n; i++)
    arrList.Add(int.Parse(inputAn[i]));

arrList.Sort();
for (int i = 1; i <= n; i++)
    dp[i] = dp[i - 1] + arrList[i - 1];

for (int i = 0; i < q; i++)
{
    string[] inputlr = Console.ReadLine().Split(' ');
    int l = int.Parse(inputlr[0]);
    int r = int.Parse(inputlr[1]);
    sb.AppendLine($"{dp[r] - dp[l - 1]}");
}

Console.WriteLine(  sb);