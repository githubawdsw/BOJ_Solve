// BOJ_1497


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

long[] state = new long[10];
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    string name = input[0];
    for (int j = m - 1; j >= 0; j--)
    {
        state[i] = state[i] << 1;
        if (input[1][j] == 'Y') 
            state[i]++;
    }
}

(long, long) ans = (0, -1);
for (int i = 0; i < (1 << n); i++)
{
    long comb = 0;
    for (int j = 0; j < m; j++)
    {
        if ((i & ((long)1 << j)) == 0)
            continue;
        comb |= state[j];
    }
    long song = BitCount(comb);
    long guitar = BitCount(i);

    if (ans.Item1 < song)
        ans = (song, guitar);
    else if(ans.Item1 == song && ans.Item2 > guitar)
        ans = (song, guitar);
}

Console.WriteLine(ans.Item2);


long BitCount(long x)
{
    long count = 0;
    for (int i = 0; i < m; i++)
    {
        count += (x >> i) & 1;
    }
    return count;
}