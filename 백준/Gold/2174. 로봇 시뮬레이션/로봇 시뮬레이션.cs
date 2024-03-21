// BOJ_2174


using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int a = inputab[0];
int b = inputab[1];

int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[] dx = { 0, 0, 1, 0, -1 };
int[] dy = { 0, 1, 0, -1, 0 };
int[,] board = new int[105, 105];
Dictionary<int, (int, int)> dict = new Dictionary<int, (int, int)>();
for (int i = 0; i < n; i++)
{
	string[] inputPos = Console.ReadLine().Split(" ");
	int x = int.Parse(inputPos[0]);
	int y = int.Parse(inputPos[1]);
    dict.Add(i + 1, (x, y));

	string dir = inputPos[2];
    if (dir == "N")
        board[x, y] = 1;
    else if (dir == "E")
        board[x, y] = 2;
    else if (dir == "S")
        board[x, y] = 3;
    else
        board[x, y] = 4;

}

for (int i = 0; i < m; i++)
{
    string[] inputCommand = Console.ReadLine().Split(" ");
    int num = int.Parse(inputCommand[0]);
    string type = inputCommand[1];
    int count = int.Parse(inputCommand[2]);

    var pos = dict[num];
    int dir = board[pos.Item1, pos.Item2];
    if(type == "F")
    {
        for (int j = 0; j < count; j++)
        {
            int nx = pos.Item1 + dx[board[pos.Item1, pos.Item2]];
            int ny = pos.Item2 + dy[board[pos.Item1, pos.Item2]];

            if(nx <= 0 || ny <= 0 || nx > a || ny > b)
            {
                Console.WriteLine($"Robot {num} crashes into the wall");
                return;
            }
            if (board[nx,ny] > 0)
            {
                int target = 0;
                foreach (var one in dict)
                {
                    if (one.Value.Item1 == nx && one.Value.Item2 == ny)
                        target = one.Key;
                }

                Console.WriteLine($"Robot {num} crashes into robot {target}");
                return;
            }

            board[nx, ny] = board[pos.Item1, pos.Item2];
            board[pos.Item1, pos.Item2] = 0;
            pos.Item1 = nx;
            pos.Item2 = ny;

            dict[num] = pos;
        }
    }

    count %= 4;
    if (type == "L")
    {
        board[pos.Item1, pos.Item2] -= count;
        if (board[pos.Item1, pos.Item2] < 1)
            board[pos.Item1, pos.Item2] += 4;
    }
    else if( type == "R")
    {
        board[pos.Item1, pos.Item2] += count;
        if (board[pos.Item1, pos.Item2] > 4)
            board[pos.Item1, pos.Item2] -= 4;
    }
}

Console.WriteLine("OK");