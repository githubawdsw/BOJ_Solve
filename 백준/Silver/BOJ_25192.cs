// BOJ_25192


int n = int.Parse(Console.ReadLine());
int count = 0;
HashSet<string> hs = new HashSet<string>();
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    if (input != "ENTER")
        hs.Add(input);
    else
    {
        count += hs.Count;
        hs = new HashSet<string>();
    }
}
count += hs.Count;
Console.WriteLine(  count );

