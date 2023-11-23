// BOJ_1004


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());

while (t-- > 0)
{
    int[] inputarr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int startx = inputarr[0];
    int starty = inputarr[1];
    int endx = inputarr[2];
    int endy = inputarr[3];

    int n = int.Parse(Console.ReadLine());

    int count = 0;
    for (int i = 0; i < n; i++)
    {
        int[] planetInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int x = planetInfo[0];
        int y = planetInfo[1];
        int r = planetInfo[2];

        int disStart = compare(startx, starty, x, y);
        int disEnd = compare(endx, endy, x, y);
        if (r * r < disStart && r * r < disEnd)
            continue;
        else if (r * r < disStart)
            count++;
        else if (r * r < disEnd)
            count++;
    }
    sb.AppendLine(count.ToString());
}

Console.WriteLine(sb);


int compare(int pointx, int pointy, int planetx, int planety)
{
    int x = pointx - planetx;
    int y = pointy - planety;

    return x * x + y * y;
}