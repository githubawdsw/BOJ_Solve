// BOJ_2641


using System.Text;

StringBuilder sb = new StringBuilder();
int length = int.Parse(Console.ReadLine());
int[] inputStandard = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = int.Parse(Console.ReadLine());

List<int[]> list = new List<int[]>();
for (int i = 0; i < n; i++)
{
    list.Add(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
}

List<int[]> arrList = new List<int[]>();
bool[,] standard = check(inputStandard);
int lx = standard.GetLength(0);
int ly = standard.GetLength(1);
for (int i = 0; i < n; i++)
{
    var one = check(list[i]);
    if (lx != one.GetLength(0) || ly != one.GetLength(1))
        continue;

    bool ch = true;
    for (int x = 0; x < lx; x++)
    {
        for (int y = 0; y < ly; y++)
        {
            if(standard[x,y] != one[x, y])
            {
                ch = false;
                break;
            }
        }
        if (!ch)
            break;
    }
    if (ch)
        arrList.Add(list[i]);
}

sb.AppendLine(arrList.Count.ToString());
for (int i = 0; i < arrList.Count; i++)
{
    for (int j = 0; j < arrList[i].Length; j++)
    {
        sb.Append(arrList[i][j] + " ");
    }
    sb.AppendLine();
}

Console.WriteLine(sb);


bool[,] check(int[] target)
{
    bool[,] temp = new bool[200, 200];
    bool[,] value;
    int[] dx = { 0, -1, 0, 1 };
    int[] dy = { 1, 0, -1, 0 };

    int minx = int.MaxValue;
    int maxx = 0;
    int miny = int.MaxValue;
    int maxy = 0;
    (int, int) pos = (100, 100);
    temp[100, 100] = true;
    for (int i = 0; i < length; i++)
    {
        int nx = pos.Item1 + dx[target[i] - 1];
        int ny = pos.Item2 + dy[target[i] - 1];

        temp[nx, ny] = true;
        pos = (nx, ny);

        minx = Math.Min(minx, nx);
        maxx = Math.Max(maxx, nx);
        miny = Math.Min(miny, ny);
        maxy = Math.Max(maxy, ny);
    }

    value = new bool[maxx - minx + 1, maxy - miny + 1];

    for (int i = minx; i <= maxx; i++)
    {
        for (int j = miny; j <= maxy; j++)
        {
            value[i - minx, j - miny] = temp[i, j] == true ? true : false;
        }
    }
    return value;
}