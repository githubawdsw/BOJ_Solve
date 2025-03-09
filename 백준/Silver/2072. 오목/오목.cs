// BOJ_2072


int n = int.Parse(Console.ReadLine());

int[] dx = { 1, -1, 0, 0, 1, -1, 1, -1 };
int[] dy = { 0, 0, 1, -1, 1, -1, -1, 1 };
int ans = 0;
bool end = false;

int[,] board = new int[21, 21];
for (int i = 0; i < n; i++)
{
    int[] inputxy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int x = inputxy[0];
    int y = inputxy[1];

    board[x, y] = i % 2 == 0 ? 1 : 2;
    ans++;
    
    if (Check(x, y, board[x, y]))
    {
        end = true;
        break;
    }
}

if (end)
    Console.WriteLine(ans);
else
    Console.WriteLine(-1);

bool Check(int x, int y, int target)
{
    Queue<(int, int)> q = new Queue<(int, int)>();
    bool isComplete = false;
    for (int i = 0; i < 8; i += 2)
    {
        int count = 1;

        q.Enqueue((x, y));
        while (q.Count > 0)
        {
            var cur = q.Dequeue();

            int nx = cur.Item1 + dx[i];
            int ny = cur.Item2 + dy[i];

            if (board[nx, ny] != target)
                break;

            count++;
            q.Enqueue((nx, ny));
        }

        q.Enqueue((x, y));
        while (q.Count > 0)
        {
            var cur = q.Dequeue();

            int nx = cur.Item1 + dx[i + 1];
            int ny = cur.Item2 + dy[i + 1];

            if (board[nx, ny] != target)
                break;

            count++;
            q.Enqueue((nx, ny));
        }
        if (count == 5)
            isComplete = true;
    }
    if(isComplete)
        return true;

    return false;
}
