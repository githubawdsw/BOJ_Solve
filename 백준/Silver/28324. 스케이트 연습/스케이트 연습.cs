// BOJ_28324


int n = int.Parse(Console.ReadLine());
int[] inputVelo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

long speed = 0;
long ans = 0;

for (int i = n - 1; i >= 0; i--)
{
    if (inputVelo[i] > speed)
        speed++;
    else
        speed = inputVelo[i];

    ans += speed;
}

Console.WriteLine(ans);