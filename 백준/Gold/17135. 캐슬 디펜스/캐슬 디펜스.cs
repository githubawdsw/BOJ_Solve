// BOJ_17135


int[] inputnmd = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnmd[0];
int m = inputnmd[1];
int d = inputnmd[2];

int[,] board = new int[20, 20];
bool[] used = new bool[20];
int enemy = 0;
for (int i = 0; i < n; i++)
{
    int[] inputEnemyPos = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 0; j < m; j++)
	{
        board[i,j] = inputEnemyPos[j];
        if (inputEnemyPos[j] == 1)
            enemy++;
	}
}

List<(int, int)> archerPosList = new List<(int, int)>();
int[,] copy;
int ans = 0;
Select(0);

Console.WriteLine(ans);


void Select(int depth)
{
    if(depth == 3)
    {
        archerPosList.Clear();
        for (int i = 0; i < m; i++)
        {
            if (used[i])
                archerPosList.Add((n, i));
        }
        copy = board.Clone() as int[,];
        Shooting();
        return;
    }
    for (int i = 0; i < m; i++)
    {
        if (used[i])
            continue;
        used[i] = true;
        Select(depth + 1);
        used[i] = false;
    }
}

void Shooting()
{
    int remain = enemy;
    int count = 0;
    while (remain != 0)
    {
        HashSet<(int,int)> targetPos = new HashSet<(int, int)>();
        for (int k = 0; k < archerPosList.Count; k++)
        {
            int min = d;
            (int, int) target = (n, m);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (copy[i, j] == 0)
                        continue;
                    int x = Math.Abs(archerPosList[k].Item1 - i);
                    int y = Math.Abs(archerPosList[k].Item2 - j);
                    if(min >= x + y)
                    {
                        if(min == x + y)
                        {
                            if(target.Item2 > j)
                                target = (i, j);
                        }
                        else
                            target = (i, j);
                        min = x + y;
                    }
                }
            }
            if(target.Item1 != n)
                targetPos.Add(target);
        }
        foreach (var one in targetPos)
        {
            copy[one.Item1, one.Item2] = 0;
            count++;
            remain--;
        }
        remain = Move(remain);
    }
    ans = Math.Max(ans, count);
}

int Move(int remain)
{
    for (int i = n - 1; i >= 0; i--)
    {
        for (int j = 0; j < m; j++)
        {
            if (copy[i, j] > 0)
            {
                copy[i, j]--;
                if (i + 1 != n)
                    copy[i + 1, j]++;
                else
                    remain--;
            }
        }
    }
    return remain;
}