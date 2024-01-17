// BOJ_13164


int[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnk[0];
int k = inputnk[1];

int[] inputHeightInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
List<int> list = new List<int>();
int ans = 0;
for (int i = 0; i < n - 1; i++)
{
    list.Add(inputHeightInfo[i + 1] - inputHeightInfo[i]);
}
list.Sort();

for (int i = 0; i < list.Count - (k - 1); i++)
{
    ans += list[i];
}

Console.WriteLine(ans);
