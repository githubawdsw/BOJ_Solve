// BOJ_15662


int t = int.Parse(Console.ReadLine());
List<List<char>> gear = new List<List<char>>();
List<(int, int)> arms = new List<(int, int)>();
int[] dx = { -1, 1 };

for (int i = 0; i < t; i++)
{
    gear.Add(new List<char>());
    string gearInfo = Console.ReadLine();
    for (int j = 0; j < 8; j++)
    {
        gear[i].Add(gearInfo[j]);
    }
    arms.Add((6, 2));
}

int k = int.Parse(Console.ReadLine());
for (int i = 0; i < k; i++)
{
    int[] inputRotateInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int num = inputRotateInfo[0];
    int dir = inputRotateInfo[1];

    Rotate(num - 1, dir);
}

int ans = 0;
for (int i = 0; i < t; i++)
{
    if (arms[i].Item2 < 2)
        ans += gear[i][8 - (2 - arms[i].Item2)] == '1' ? 1 : 0;
    else
        ans += gear[i][arms[i].Item2 - 2] == '1' ? 1 : 0;
}

Console.WriteLine(ans);

void Rotate(int gearNum , int dir)
{
    bool[] vis = new bool[1005];
    Stack<(int, int)> s = new Stack<(int, int)>();

    vis[gearNum] = true;
    s.Push((gearNum, dir));

    while (s.Count > 0)
    {
        var cur = s.Pop();

        int leftArm = arms[cur.Item1].Item1;
        int rightArm = arms[cur.Item1].Item2;

        for (int i = 0; i < 2; i++)
        {
            int nx = cur.Item1 + dx[i];

            if (nx < 0 || nx >= t || vis[nx])
                continue;

            if(i == 0)
            {
                if (gear[cur.Item1][leftArm] != gear[nx][arms[nx].Item2])
                    s.Push((nx, cur.Item2 == 1 ? -1 : 1));
            }
            if(i == 1)
            {
                if (gear[cur.Item1][rightArm] != gear[nx][arms[nx].Item1])
                    s.Push((nx, cur.Item2 == 1 ? -1 : 1));
            }
            vis[nx] = true;
        }

        if (cur.Item2 == 1)
        {
            if (--leftArm == -1)
                leftArm = 7;
            if(--rightArm == -1)
                rightArm = 7;
        }
        else
        {
            if (++leftArm == 8)
                leftArm = 0;
            if (++rightArm == 8)
                rightArm = 0;
        }

        arms[cur.Item1] = (leftArm, rightArm);
    }
}