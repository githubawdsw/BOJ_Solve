// BOJ_2527


using System.Text;

StringBuilder sb = new StringBuilder();
int xleft, xright, ytop, ybottom;
for (int i = 0; i < 4; i++)
{
    int[] inputarr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    int x1 = inputarr[0];
    int y1 = inputarr[1];
    int p1 = inputarr[2];
    int q1 = inputarr[3];

    int x2 = inputarr[4];
    int y2 = inputarr[5];
    int p2 = inputarr[6];
    int q2 = inputarr[7];

    xleft = Math.Max(x1, x2);
    xright = Math.Min(p1, p2);
    ybottom = Math.Max(y1, y2);
    ytop = Math.Min(q1, q2);

    int xlen = xright - xleft;
    int ylen = ytop - ybottom;

    if (xlen > 0 && ylen > 0)
        sb.AppendLine("a");
    else if (xlen < 0 || ylen < 0)
        sb.AppendLine("d");
    else if (xlen == 0 && ylen == 0)
        sb.AppendLine("c");
    else
        sb.AppendLine("b");
}

Console.WriteLine(sb);
