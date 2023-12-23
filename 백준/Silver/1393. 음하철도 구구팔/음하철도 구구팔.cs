// BOJ_1393


int[] inputStation = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int sx = inputStation[0];
int sy = inputStation[1];

int[] inputCurJumpPoint = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int ex = inputCurJumpPoint[0];
int ey = inputCurJumpPoint[1];
int dx = inputCurJumpPoint[2];
int dy = inputCurJumpPoint[3];

int min = int.MaxValue;
int ans1 = 0;
int ans2 = 0;
int mod = GCD(dx, dy);

while (true)
{
    int dis = (sx - ex) * (sx - ex) + (sy - ey) * (sy - ey);
    if (min < dis)
        break;
    min = dis;

    ans1 = ex;
    ans2 = ey;

    ex += dx / mod;
    ey += dy / mod;
}

Console.WriteLine($"{ans1} {ans2}");


int GCD(int a, int b)
{
    if (b == 0)
        return a;
    return GCD(b, a % b);
}