// BOJ_16434



int[] inputna = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputna[0];
long att = inputna[1];

List<Tuple<long, long, long>> list = new List<Tuple<long, long, long>>();
for (int i = 0; i < n; i++)
{
    long[] info = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
    long t = info[0];
    long a = info[1];
    long h = info[2];
    list.Add(new Tuple<long, long, long>(t, a, h));
}

long ans = 0;
long turn = 1;
long start = 1;
long end = (long)1000000 * 1000000 * n;
while (start <= end)
{
    turn = att;
    long mid = (start + end) / 2;
    long temp = mid;
    for (int i = 0; i < n; i++)
    {
        if (list[i].Item1 == 1)
        {
            long val = list[i].Item3 % turn;
            if (val == 0)
                temp -= (list[i].Item3 / turn - 1) * list[i].Item2;
            else
                temp -= (list[i].Item3 / turn) * list[i].Item2;
        }
        else
        {
            turn += list[i].Item2;
            temp += list[i].Item3;
            if (temp >= mid)
                temp = mid;
        }
        if (temp <= 0)
            break;
    }
    if (temp > 0)
    {
        ans = mid;
        end = mid - 1;
    }
    else
        start = mid + 1;
}


Console.WriteLine(  ans );
