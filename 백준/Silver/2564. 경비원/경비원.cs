// BOJ_2564



int[] inputwh = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int width = inputwh[0];
int height = inputwh[1];
int store = int.Parse(Console.ReadLine());
List<(int, int)> storeList = new List<(int, int)>();
for (int i = 0; i < store; i++)
{
    int[] storePoint = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int dir = storePoint[0];
    int dis = storePoint[1];

    storeList.Add((dir, dis));
}

int[] curPoint = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int ans = 0;
for (int i = 0; i < store; i++)
{
    var cur = storeList[i];
    if (curPoint[0] == 1)
    {
        if (cur.Item1 == 1)
            ans += Math.Abs(cur.Item2 - curPoint[1]);
        else if (cur.Item1 == 2)
            ans += height + Math.Min(cur.Item2 + curPoint[1], width * 2 - (cur.Item2 + curPoint[1]));
        else if (cur.Item1 == 3)
            ans += cur.Item2 + curPoint[1];
        else
            ans += width - curPoint[1] + cur.Item2;
    }
    else if (curPoint[0] == 2)
    {
        if (cur.Item1 == 1)
            ans += height + Math.Min(cur.Item2 + curPoint[1], width * 2 - (cur.Item2 + curPoint[1]));
        else if (cur.Item1 == 2)
            ans += Math.Abs(cur.Item2 - curPoint[1]);
        else if (cur.Item1 == 3)
            ans += height - cur.Item2 + curPoint[1];
        else
            ans += width - curPoint[1] + height - cur.Item2;
    }
    else if (curPoint[0] == 3)
    {
        if (cur.Item1 == 1)
            ans += curPoint[1] + cur.Item2;
        else if (cur.Item1 == 2)
            ans += height - curPoint[1] + cur.Item2;
        else if (cur.Item1 == 3)
            ans += Math.Abs(cur.Item2 - curPoint[1]);
        else
            ans += width + Math.Min(cur.Item2 + curPoint[1], height * 2 - (cur.Item2 + curPoint[1]));
    }
    else
    {
        if (cur.Item1 == 1)
            ans += curPoint[1] + width - cur.Item2;
        else if (cur.Item1 == 2)
            ans += height - curPoint[1] + width - cur.Item2;
        else if (cur.Item1 == 3)
            ans += width + Math.Min(cur.Item2 + curPoint[1], height * 2 - (cur.Item2 + curPoint[1]));
        else
            ans += Math.Abs(cur.Item2 - curPoint[1]);
    }
}

Console.WriteLine(ans);