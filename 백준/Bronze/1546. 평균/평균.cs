// BOJ_1546


int n = int.Parse(Console.ReadLine());
int[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int max = inputnk.Max();

float ans = 0;
for (int i = 0; i < inputnk.Length; i++)
{
    int value = inputnk[i] * 10000 / max;
    ans += (float)value / 100;
}

Console.WriteLine(ans / inputnk.Length);