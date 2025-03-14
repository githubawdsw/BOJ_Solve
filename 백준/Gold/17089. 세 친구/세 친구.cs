// BOJ_17089


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int ans = int.MaxValue;
List<int>[] list = new List<int>[4005];
for (int i = 0; i < m; i++)
{
    int[] inputRel = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    int x = inputRel[0];
    int y = inputRel[1];

    if (list[x] == null)
        list[x] = new List<int>();
    list[x].Add(y);

    if (list[y] == null)
        list[y] = new List<int>();
    list[y].Add(x);
}

for (int fir = 1; fir <= n; fir++)
{
    if (list[fir] == null)
        continue;

    for (int i = 0; i < list[fir].Count; i++)
    {
        int sec = list[fir][i];

        if (sec <= fir || list[sec] == null)
            continue;

        for (int j = 0; j < list[sec].Count; j++)
        {
            int thr = list[sec][j];

            if (thr <= sec || !list[fir].Contains(thr))
                continue;

            ans = Math.Min(ans, list[fir].Count - 2 + list[sec].Count - 2 + list[thr].Count - 2);
        }
    }
}

if(ans == int.MaxValue)
    Console.WriteLine(-1);
else
    Console.WriteLine(ans);