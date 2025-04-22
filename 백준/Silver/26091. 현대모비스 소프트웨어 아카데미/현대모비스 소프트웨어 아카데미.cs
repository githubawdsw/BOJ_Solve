// BOJ_26091


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[] inputScore = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

Array.Sort(inputScore);
int left = 0;
int right = n - 1;
int ans = 0;
while (left < right)
{
    int sum = inputScore[left] + inputScore[right];
    if (sum >= m)
    {
        right--;
        ans++;
    }
    left++;
}

Console.WriteLine(ans);