// BOJ_26069


int n = int.Parse(Console.ReadLine());
Dictionary<string, bool> dict = new Dictionary<string, bool>
{
    { "ChongChong", true }
};

for (int i = 0; i < n; i++)
{
    string[] inputrel = Console.ReadLine().Split(' ');
    if (dict.ContainsKey(inputrel[1]) && dict[inputrel[1]] == true)
        dict[inputrel[0]] = true;
    else if (dict.ContainsKey(inputrel[0]) && dict[inputrel[0]] == true)
        dict[inputrel[1]] = true;
}
Console.WriteLine(  dict.Count);

