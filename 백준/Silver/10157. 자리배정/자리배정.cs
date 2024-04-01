// BOJ_10157


int[] inputcr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int c = inputcr[0];
int r = inputcr[1];
int k = int.Parse(Console.ReadLine());

int[,] dis = new int[1005, 1005];
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };

if(k > r * c)
{
    Console.WriteLine(0);
    return;
}

dis[1,1] = 1;
int count = 1;
(int, int, int) pos = (1, 1, 0);
while (count < k)
{
    int nx = pos.Item1 + dx[pos.Item3];
    int ny = pos.Item2 + dy[pos.Item3];

    if (count > k)
        break;
    if (nx < 1 || ny < 1 || nx > r || ny > c || dis[nx, ny] != 0)
    {
        int dir = (pos.Item3 + 1) % 4;
        pos = (pos.Item1, pos.Item2, dir);
        if (count == k)
            break;
        continue;
    }

    pos = (nx, ny, pos.Item3);
    dis[nx, ny] = ++count;
}

Console.WriteLine($"{pos.Item2} {pos.Item1}");
