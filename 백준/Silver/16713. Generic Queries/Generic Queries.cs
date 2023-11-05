// BOJ_16713


int[] inputnq = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnq[0];
int q = inputnq[1];

int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] xor = new int[1000005];
for (int i = 1; i <= n; i++)
{
    xor[i] = xor[i - 1] ^ arr[i - 1];
}

int ans = 0;
for (int i = 0; i < q; i++)
{
    int[] inputse = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int s = inputse[0];
    int e = inputse[1];
    
    int sum = xor[s-1] ^ xor[e];
    ans ^= sum;
}

Console.WriteLine(ans);