// BOJ_2942

using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputrg = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int r = inputrg[0];
int g = inputrg[1];

int gcd = GCD(r, g);
HashSet<int> hs = new HashSet<int>();
for (int i = 1; i <= gcd / 2; i++)
{
    if(gcd % i == 0)
    {
        hs.Add(i);
    }
}
hs.Add(gcd);
foreach (var one in hs)
{
    sb.AppendLine($"{one} {r / one} {g / one}");
}

Console.WriteLine(sb);


int GCD(int a, int b){
    if (b == 0)
        return a;
    return GCD(b, a % b);
}