// BOJ_20115


int n = int.Parse(Console.ReadLine());
float[] inputAmount = Array.ConvertAll(Console.ReadLine().Split(), float.Parse);
Array.Sort(inputAmount);

for (int i = 0; i < n - 1; i++)
    inputAmount[n - 1] += inputAmount[i] / 2;

Console.WriteLine(inputAmount[n-1]);
