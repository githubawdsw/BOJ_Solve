// BOJ_14891


List<List<char>> list = new List<List<char>>();
List<(int, int)> armsInfo = new List<(int, int)>();
for (int i = 0; i < 4; i++)
{
    string gearInfo = Console.ReadLine();
    list.Add(new List<char>());
    for (int j = 0; j < 8; j++)
    {
        list[i].Add(gearInfo[j]);
    }
    armsInfo.Add((6, 2));
}

int k = int.Parse(Console.ReadLine());
for (int i = 0; i < k; i++)
{
    int[] inputnd = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int n = inputnd[0];
    int dir = inputnd[1];

    bool[] vis = new bool[4];

    Rotate(n - 1, dir, vis);
}

int ans = 0;
for (int i = 0; i < 4; i++)
{
    int upInfo = armsInfo[i].Item2 - 2;
    if (upInfo < 0)
        upInfo += 8;
    var up = list[i][upInfo];
    if (up == '1')
        ans += (int)Math.Pow(2, i);
}

Console.WriteLine(ans);


void Rotate(int gearNum, int dir, bool[] vis)
{
    int left = armsInfo[gearNum].Item1;
    int right = armsInfo[gearNum].Item2;

    vis[gearNum] = true;
    if (gearNum + 1 < 4 && !vis[gearNum + 1])
    {
        if (list[gearNum][armsInfo[gearNum].Item2] != list[gearNum + 1][armsInfo[gearNum + 1].Item1])
            Rotate(gearNum + 1, dir * -1, vis);
    }
    if (gearNum - 1 >= 0 && !vis[gearNum - 1])
    {
        if (list[gearNum][armsInfo[gearNum].Item1] != list[gearNum - 1][armsInfo[gearNum - 1].Item2])
            Rotate(gearNum - 1, dir * -1, vis);
    }

    if (dir == 1)
    {
        if (--left == -1)
            left = 7;

        if (--right == -1)
            right = 7;
    }
    if (dir == -1)
    {
        if (++left == 8)
            left = 0;

        if (++right == 8)
            right = 0;
    }
    armsInfo[gearNum] = (left, right);
}