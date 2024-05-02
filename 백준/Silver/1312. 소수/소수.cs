// BOJ_1312


int[] inputabn = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int a = inputabn[0];
int b = inputabn[1];
int n = inputabn[2];

int ans = 0;
for (int i = 0; i <= n; i++)
{
    ans = a / b;
    a = a % b * 10;
}

Console.WriteLine(ans);