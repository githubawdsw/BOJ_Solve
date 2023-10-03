// BOJ_9184

using System.Text;

StringBuilder sb = new StringBuilder();
string[] input;
int[,,] dp = new int[23, 23, 23];
while (true)
{
    input = Console.ReadLine().Split(' ');
    if (input[0] == "-1" && input[1] == "-1" && input[2] == "-1")
        break;
    int a = int.Parse(input[0]);
    int b = int.Parse(input[1]);
    int c = int.Parse(input[2]);
    sb.AppendLine($"w({a}, {b}, {c}) = {recursive(a, b, c)}");
}
Console.WriteLine(  sb);


int recursive(int a ,int b, int c)
{
    if (a <= 0 || b <= 0 || c <= 0)
        return 1;
    else if (a > 20 || b > 20 || c > 20)
        return recursive(20, 20, 20);
    else if (dp[a, b, c] != 0)
        return dp[a, b, c];
    else if (a < b && b < c)
        return dp[a, b, c] = recursive(a, b, c - 1) + recursive(a, b - 1, c - 1) - recursive(a, b - 1, c);
    else
        return dp[a, b, c] = recursive(a - 1, b, c) + recursive(a - 1, b - 1, c) + recursive(a - 1, b, c - 1) - recursive(a - 1, b - 1, c - 1);
}

