// BOJ_1793


using System.Numerics;


BigInteger[] bigintDp = new BigInteger[251];
bigintDp[0] = 1;
bigintDp[1] = 1;
for (int i = 2; i <= 250; i++)
{
    bigintDp[i] = bigintDp[i - 1] + (2 * bigintDp[i - 2]);
}
while (true)
{
    string n = Console.ReadLine();
    if (n == null)
        break;
    Console.WriteLine(bigintDp[int.Parse(n)]);
}