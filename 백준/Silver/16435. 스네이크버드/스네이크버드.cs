// BOJ_16435


int[] inputnl = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnl[0];
int l  = inputnl[1];
int[] height = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Array.Sort(height);

for (int i = 0; i < n; i++)
{
    if (height[i] <= l)
        l++;
}

Console.WriteLine(l);
