// BOJ_14247


int n = int.Parse(Console.ReadLine());
long[] inputInitialHeight = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
int[] inputGrowlHeight = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

Dictionary<int, int> dictGrow = new Dictionary<int, int>();

for (int i = 0; i < n; i++)
{
    dictGrow.Add(i, inputGrowlHeight[i]);
}

dictGrow = dictGrow.OrderBy(x => x.Value).ToDictionary(x => x.Key, y => y.Value);
long ans = 0;
int count = 0;
foreach (var one in dictGrow)
{
    ans += inputInitialHeight[one.Key] + count * one.Value;
    count++;
}

Console.WriteLine(ans);
