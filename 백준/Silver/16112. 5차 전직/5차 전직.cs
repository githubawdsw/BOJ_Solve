// BOJ_16112


int[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnk[0];
int k = inputnk[1];

long[] inputQuestArr = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

Array.Sort(inputQuestArr);
long ans = 0;
for (int i = 0; i < k; i++)
{
    ans += inputQuestArr[i] * i;
}
for (int i = k; i < n; i++)
{
    ans += inputQuestArr[i] * k;
}

Console.WriteLine(ans);