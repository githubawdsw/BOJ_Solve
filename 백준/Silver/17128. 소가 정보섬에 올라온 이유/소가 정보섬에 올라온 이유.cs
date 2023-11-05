// BOJ_17128



using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputnq = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnq[0];
int q = inputnq[1];

int[] cowArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] prank = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

long[] mul = new long[200005];
for (int i = 0; i < n; i++)
{
    mul[i] = cowArr[i % n] * cowArr[(i + 1) % n] * cowArr[(i + 2) % n] * cowArr[(i + 3) % n];
}

long sum = 0;
for (int i = 0; i < n; i++)
    sum += mul[i];
for (int i = 0; i < q; i++)
{
    int val = prank[i];
    mul[(n + val - 1) % n] *= -1;
    mul[(n + val - 2) % n] *= -1;
    mul[(n + val - 3) % n] *= -1;
    mul[(n + val - 4) % n] *= -1;
    sum = sum + 2 * (mul[(n + val - 1) % n] + mul[(n + val - 2) % n] + mul[(n + val - 3) % n] + mul[(n + val - 4) % n]);
    sb.AppendLine(sum.ToString());
}
Console.WriteLine(sb);

