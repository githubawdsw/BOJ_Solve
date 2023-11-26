// BOJ_9063

int n = int.Parse(Console.ReadLine());
int minx = int.MaxValue;
int maxx = int.MinValue;
int miny = int.MaxValue;
int maxy = int.MinValue;

for (int i = 0; i < n; i++)
{
    int[] inputxy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int x = inputxy[0];
    int y = inputxy[1];
    minx = Math.Min(minx, x);
    maxx = Math.Max(maxx, x);
    miny = Math.Min(miny ,y);
    maxy= Math.Max(maxy , y);
}

int ans = (maxx - minx) * (maxy - miny);
Console.WriteLine(ans);