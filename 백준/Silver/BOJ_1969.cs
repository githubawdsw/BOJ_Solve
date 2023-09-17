// BOJ_1969


using System.Text;

string[] inputnm = Console.ReadLine().Split(' ');
int n = int.Parse(inputnm[0]);
int m = int.Parse(inputnm[1]);

List<string> stringlist = new List<string>();
for (int i = 0; i < n; i++)
{
    string s = Console.ReadLine();
    stringlist.Add(s);
}

string ans = "";
int counting = 0;
int[] count;
for (int i = 0; i < m; i++)
{
    count = new int[4];
    // A == 0, C ==1 , G == 2, T == 3
    for (int j = 0; j < n; j++)
    {
        if (stringlist[j][i] == 'A')
            count[0]++;
        else if (stringlist[j][i] == 'C')
            count[1]++;
        else if (stringlist[j][i] == 'G')
            count[2]++;
        else if (stringlist[j][i] == 'T')
            count[3]++;
    }
    int max = count.Max();
    int idx = Array.IndexOf(count, max);
    if (idx == 0)
        ans += 'A';
    else if (idx == 1)
        ans += 'C';
    else if (idx == 2)
        ans += 'G';
    else if (idx == 3)
        ans += 'T';
    counting += n - max;
}
Console.WriteLine(  ans);
Console.WriteLine( counting);

