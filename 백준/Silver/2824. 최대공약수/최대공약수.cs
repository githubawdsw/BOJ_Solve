// BOJ_2824


int n = int.Parse(Console.ReadLine());
int[] inputnArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int m = int.Parse(Console.ReadLine());
int[] inputmArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

List<long> listN = new List<long>();
List<long> listM = new List<long>();
for (int i = 0; i < n; i++)
{
    listN.Add(inputnArr[i]);
}
for (int j = 0; j < m; j++)
{
    listM.Add(inputmArr[j]);
}

long ans = 1;
bool check = false;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        long gcd = GCD(listN[i], listM[j]);
        ans *= gcd;
        if (ans >= 1000000000)
        {
            ans %= 1000000000;
            check = true;
        }

        listN[i] /= gcd;
        listM[j] /= gcd;
    }
}

if (!check)
    Console.WriteLine(ans);
else
{
    string str = ans.ToString();
    string value = "";
    for (int i = 0; i < 9 - str.Length; i++)
    {
        value += '0';
    }
    Console.WriteLine(value + ans);
}




long GCD(long x, long y)
{
    if (y == 0)
        return x;
    return GCD(y, x % y);
}