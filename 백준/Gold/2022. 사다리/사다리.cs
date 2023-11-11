// BOJ_2022


double[] inputxyc = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
double x = inputxyc[0];
double y = inputxyc[1];
double c = inputxyc[2];

double start = 0;
double end = Math.Min(x, y);
double ans = 0;
while (end - start > 0.000001)
{
    double mid = (end + start) / 2;
    if (solve(mid) < c)
        end = mid;
    else
    {
        ans = mid;
        start = mid;
    }
}
Console.WriteLine(Math.Round(ans , 3));


double solve(double mid)
{
    double numerator = Math.Sqrt(x * x - mid * mid) * Math.Sqrt(y * y - mid * mid);
    double denominator = Math.Sqrt(x * x - mid * mid) + Math.Sqrt(y * y - mid * mid);
    return (numerator / denominator);
}