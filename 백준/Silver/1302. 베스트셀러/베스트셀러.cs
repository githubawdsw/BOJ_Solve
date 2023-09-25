// BOJ_1302


int n = int.Parse(Console.ReadLine());
Dictionary<string, int> dict = new Dictionary<string, int>();
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    if(!dict.ContainsKey(input))
        dict[input] = 0;
    dict[input]++;
}
dict = dict.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key).ToDictionary(x => x.Key, y => y.Value);

Console.WriteLine( dict.First().Key );
