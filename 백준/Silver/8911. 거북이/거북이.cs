// BOJ_8911


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());
int[] dx = { -1, 0, 1, 0 };
int[] dy = { 0, 1, 0, -1 };
while (t-- > 0)
{
    string control = Console.ReadLine();

    int minx = 0;
    int maxx = 0;
    int miny = 0;
    int maxy = 0;

    int dir = 0;
    (int, int) pos = (0, 0);
    for (int i = 0; i < control.Length; i++)
    {
        if (control[i] == 'F')
        {
            int nx = pos.Item1 + dx[dir];
            int ny = pos.Item2 + dy[dir];

            minx = Math.Min(minx, nx);
            maxx = Math.Max(maxx, nx);
            miny = Math.Min(miny, ny);
            maxy = Math.Max(maxy, ny);

            pos = (nx, ny);
        }

        else if (control[i] == 'B')
        {
            int nx = pos.Item1 - dx[dir];
            int ny = pos.Item2 - dy[dir];

            minx = Math.Min(minx, nx);
            maxx = Math.Max(maxx, nx);
            miny = Math.Min(miny, ny);
            maxy = Math.Max(maxy, ny);

            pos = (nx, ny);
        }
        else if (control[i] == 'R')
        {
            if(++dir > 3)
                dir = 0;
        }
        else if (control[i] == 'L')
        {
            if (--dir < 0)
                dir = 3;
        }
    }

    int area = Math.Abs(maxx - minx) * Math.Abs(maxy -  miny);
    sb.AppendLine(area.ToString());
}

Console.WriteLine(sb);
