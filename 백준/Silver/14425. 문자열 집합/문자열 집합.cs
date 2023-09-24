// BOJ_14425


string[] inputnm = Console.ReadLine().Split(' ');
int n = int.Parse(inputnm[0]);
int m = int.Parse(inputnm[1]);

List<string> sl = new List<string>();
for (int i = 0; i < n; i++)
{
    string inputs = Console.ReadLine();
    sl.Add(inputs);
}

sl.Sort();
int ans = 0;
for (int i = 0; i < m; i++)
{
    string str = Console.ReadLine();
    int idx = sl.BinarySearch(str);
    if ( idx < n && idx >= 0)
        ans++;
}
Console.WriteLine(  ans);
