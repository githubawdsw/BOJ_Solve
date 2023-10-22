// BOJ_1584



int[,] board = new int[505, 505];
int[,] dis = new int[505, 505];
bool[,] vis = new bool[505, 505];
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };

int n = int.Parse(Console.ReadLine());
int dangerx1 = 0, dangery1 = 0, dangerx2 = 0, dangery2 = 0;
for (int i = 0; i < n; i++)
{
    string[] inputDanger = Console.ReadLine().Split(' ');
    dangerx1 = int.Parse(inputDanger[0]);
    dangery1 = int.Parse(inputDanger[1]);
    dangerx2 = int.Parse(inputDanger[2]);
    dangery2 = int.Parse(inputDanger[3]);

    int x = Math.Max(dangerx1, dangerx2);
    int y = Math.Max(dangery1, dangery2);
    for (int k = Math.Min(dangerx1, dangerx2); k <= x; k++)
    {
        for (int j = Math.Min(dangery1, dangery2); j <= y; j++)
        {
            board[k, j] = 1;
            dis[k, j] = int.MaxValue / 2;
        }
    }
}

int m = int.Parse(Console.ReadLine());
int deathx1 = 0, deathy1 = 0, deathx2 = 0, deathy2 = 0;
for (int i = 0; i < m; i++)
{
    string[] inputDeath = Console.ReadLine().Split(' ');
    deathx1 = int.Parse(inputDeath[0]);
    deathy1 = int.Parse(inputDeath[1]);
    deathx2 = int.Parse(inputDeath[2]);
    deathy2 = int.Parse(inputDeath[3]);

    int x = Math.Max(deathx1, deathx2);
    int y = Math.Max(deathy1, deathy2);
    for (int k = Math.Min(deathx1, deathx2); k <= x; k++)
    {
        for (int j = Math.Min(deathy1, deathy2); j <= y; j++)
            vis[k,j] = true;
    }
}

if (vis[500,500])
{
    Console.WriteLine(  -1 );
    return;
}    
dis[0, 0] = 0;
vis[0, 0] = true;

PriorityQueue<Tuple<int, int>, int> pq = new PriorityQueue<Tuple<int, int>, int>();
pq.Enqueue(new Tuple<int, int>(0, 0) , 0);

while (pq.Count > 0)
{
    var cur = pq.Dequeue();
    for (int i = 0; i < 4; i++)
    {
        int nx = dx[i] + cur.Item1;
        int ny = dy[i] + cur.Item2;
        if (nx < 0 || ny < 0 || nx > 500 || ny > 500)
            continue;
        if ( vis[nx, ny])
            continue;
        if (board[nx, ny] == 1)
            dis[nx, ny] = dis[cur.Item1, cur.Item2] + 1;
        else if (board[nx, ny] == 0)
            dis[nx, ny] = dis[cur.Item1, cur.Item2];
        vis[nx, ny] = true;
        pq.Enqueue(new Tuple<int, int>(nx, ny), dis[nx,ny]);
    }
}


if ( !vis[500,500])
    Console.WriteLine(-1);
else
    Console.WriteLine(dis[500, 500]);
