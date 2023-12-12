// BOJ_1205


int[] inputntp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int n = inputntp[0];
int taesu = inputntp[1];
int p = inputntp[2];

if(n == 0)
{
    Console.WriteLine(1);
    return;
}
int[] pointArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

pointArr = pointArr.OrderByDescending(x => x).ToArray();
int ans = -1;
bool check = false;
for (int i = 0; i < n; i++)
{
    if (i >= p)
        break;
    if (taesu == pointArr[i] && !check)
    {
        ans = i + 1;
        check = true;
    }
    else if (taesu > pointArr[i] && !check)
    {
        if (i > 0 && taesu == pointArr[i - 1])
            ans = i;
        else
            ans = i + 1;
        break;
    }
    else if (taesu < pointArr[i] && !check)
    {
        ans = i + 2;
    }
}
if (ans == 0)
    ans = 1;


if (ans > p)
    ans = -1;
if (p <= pointArr.Length && taesu == pointArr[p - 1])
    ans = -1;

Console.WriteLine(ans);
