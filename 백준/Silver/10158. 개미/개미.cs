// BOJ_10158


int[] inputwh = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int w = inputwh[0];
int h = inputwh[1];

int[] inputpq = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int p = inputpq[0];
int q = inputpq[1];

int t = int.Parse(Console.ReadLine());

int posx = (q + t) / h;
int posy = (p + t) / w;

int remainx = (q + t) % h;
int remainy = (p + t) % w;

if (posx % 2 == 1)
    remainx = h - remainx;
if (posy % 2 == 1)
    remainy = w - remainy;

Console.WriteLine($"{remainy} {remainx}");