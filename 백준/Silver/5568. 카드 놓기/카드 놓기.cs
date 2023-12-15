// BOJ_5568

using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
int k = int.Parse(Console.ReadLine());

HashSet<string> hs = new HashSet<string>();
string[] inputArr = new string[15];
bool[] checkArr = new bool[15];

for (int i = 0; i < n; i++)
    inputArr[i] = Console.ReadLine();

dfs(0 , 0 , "");
Console.WriteLine(hs.Count);


void dfs(int idx, int length , string str)
{
    if(length == k)
    {
        if (!hs.Contains(str))
            hs.Add(str);
    }

    for (int i = 0; i < n; i++)
    {
        if (checkArr[i])
            continue;
        checkArr[i] = true;
        dfs(i + 1 , length + 1 , str + inputArr[i]);
        checkArr[i] = false;
    }
}