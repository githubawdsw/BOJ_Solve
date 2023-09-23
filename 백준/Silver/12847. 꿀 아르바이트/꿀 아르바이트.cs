// BOJ_12847


string[] inputnm = Console.ReadLine().Split(' ');
int n = int.Parse(inputnm[0]);
int m = int.Parse(inputnm[1]);

string[] inputT = Console.ReadLine().Split(" ");

long ans = 0;
for (int i = 0; i < m; i++)
    ans += int.Parse(inputT[i]);

long temp = ans;
for (int i = m; i < n; i++)
{
    temp = temp + int.Parse(inputT[i]) - int.Parse(inputT[i - m]);
    ans = Math.Max(ans, temp);
}

Console.WriteLine(ans);
