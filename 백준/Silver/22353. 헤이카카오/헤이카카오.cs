// BOJ_22353


int[] inputadk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int a = inputadk[0];
double d = (double)inputadk[1] / 100;
double k = (double)inputadk[2] / 100;

double ans = 0;
double lose = 1;
int time = 1;
while (true)
{
    ans += time * a * lose * d;
    time++;
    if (d >= 1)
        break;
    
    lose = lose * (1 - d);
    d += d * k;

    if (d >= 1)
        d = 1;
}

Console.WriteLine(ans);