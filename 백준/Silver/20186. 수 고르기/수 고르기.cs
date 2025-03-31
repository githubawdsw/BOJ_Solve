// BOJ_20186


int[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnk[0];
int k = inputnk[1];

int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Dictionary<int, int> dict = new Dictionary<int, int>();
List<(int, int)> list = new List<(int, int)>();
int ans = 0;
for (int i = 0; i < n; i++)
{
    dict.Add(i, inputArr[i]);
}

dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);

int idx = 0;
foreach (var one in dict)
{
    if (++idx > k)
        break;
    list.Add((one.Key, one.Value));
}

list.Sort();
for (int i = 0; i < k; i++)
{
    ans += list[i].Item2 - i;
}

Console.WriteLine(ans);