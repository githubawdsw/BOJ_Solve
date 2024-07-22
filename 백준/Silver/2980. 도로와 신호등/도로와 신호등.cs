// BOJ_2980


int[] inputnl = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnl[0];
int l = inputnl[1];

int time = 0;
int pos = 0;
for (int i = 0; i < n; i++)
{
    int[] inputdrg = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int d = inputdrg[0];
    int r = inputdrg[1];
    int g = inputdrg[2];

    int cycle = r + g;
    time += d - pos;
    pos = d;

    if (time % cycle <= r)
        time += r - (time % cycle);
}

if (pos != l)
    time += l - pos;

Console.WriteLine(time);