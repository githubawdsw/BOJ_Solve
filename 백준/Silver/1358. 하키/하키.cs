// BOJ_1358



int[] inputwhxyp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int w = inputwhxyp[0];
int h = inputwhxyp[1];
int x = inputwhxyp[2];
int y = inputwhxyp[3];
int p = inputwhxyp[4];

int count = 0;
for (int i = 0; i < p; i++)
{
    int[] inputCoordinate = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int px = inputCoordinate[0];
    int py = inputCoordinate[1];

    if (px >= x && px <= x + w && py >= y && py <= y + h)
        count++;
    else
    {
        int len = 0;
        if (x > px)
        {
            px -= x;
            py -= y + (h / 2);
            len = px * px + py * py;
        }
        else if (x + w < px)
        {
            px -= x + w;
            py -= y + (h / 2);
            len = px * px + py * py;
        }
        else
            len = h * h;

        int r = (h / 2) * (h / 2);
        if (len <= r)
            count++;
    }
}

Console.WriteLine(count);
