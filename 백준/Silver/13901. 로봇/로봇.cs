// BOJ_13901


int[,] board = new int[1005, 1005];
bool[,] vis = new bool[1005, 1005];

string[] inputrc = Console.ReadLine().Split(' ');
int r = int.Parse(inputrc[0]);
int c = int.Parse(inputrc[1]);

int k = int.Parse(Console.ReadLine());
for (int i = 0; i < k; i++)
{
    string[] inputb = Console.ReadLine().Split(' ');
    int br = int.Parse(inputb[0]);
    int bc = int.Parse(inputb[1]);

    board[br, bc] = 1;
}

string[] inputStart = Console.ReadLine().Split(' ');
int x = int.Parse(inputStart[0]);
int y = int.Parse(inputStart[1]);
vis[x, y] = true;

string[] inputMove = Console.ReadLine().Trim().Split(' ');

while (true)
{
    int beforex = x;
    int beforey = y;
    for(int i = 0; i < inputMove.Length; i++)
    {
        int nx = x;
        int ny = y;
        while (true)
        {
            switch (int.Parse(inputMove[i]))
            {
                case 1:
                    nx--;
                    break;
                case 2:
                    nx++;
                    break;
                case 3:
                    ny--;
                    break;
                case 4:
                    ny++;
                    break;
                default:
                    break;
            }
            if (nx < 0 || ny < 0 || nx >= r || ny >= c)
                break;

            if (board[nx, ny] == 1 || vis[nx, ny])
                break;

            vis[nx, ny] = true;
            x = nx;
            y = ny;
        }
    }
    if (beforex == x && beforey == y)
        break;
}

string ans = x + " " + y;
Console.WriteLine(ans);