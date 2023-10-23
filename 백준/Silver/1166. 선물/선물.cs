// BOJ_1166



int[] inputval = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
long n = inputval[0];
long l = inputval[1];
long w = inputval[2];
long h = inputval[3];

double start = 0;
double end = Math.Max(l, Math.Max(w,h));
int count = 500000;
while (count-- > 0)
{
    double mid = (start + end) / 2;
    if ((long)(l / mid) * (long)(w / mid) * (long)(h / mid) < n)
        end = mid;
    else
        start = mid;
}

Console.WriteLine(  start );