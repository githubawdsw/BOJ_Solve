// BOJ_17087


int[] inputns = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputns[0];
int s = inputns[1];

int[] inputA = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int ans = Math.Abs(s - inputA[0]);
for (int i = 1; i < n; i++)
{
    ans = GCD(ans, Math.Abs(s - inputA[i]));
}

Console.WriteLine(ans);


int GCD(int a ,int b)
{
    if (b == 0)
        return a;
    return GCD(b, a % b);
}