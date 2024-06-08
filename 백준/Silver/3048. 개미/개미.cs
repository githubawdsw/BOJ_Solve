// BOJ_3048


using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputn = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n1 = inputn[0];
int n2 = inputn[1];

string n1Arr = Console.ReadLine();
string n2Arr = Console.ReadLine();

int t = int.Parse(Console.ReadLine());

List<(char, int)> list = new List<(char, int)>();
for (int i = 0; i < n1; i++)
{
    list.Add((n1Arr[n1 - 1 - i], 0));
}
for (int i = 0; i < n2; i++)
{
    list.Add((n2Arr[i], 1));
}


while (t-- > 0)
{
    for (int i = 0; i < list.Count - 1; i++)
    {
        if (list[i].Item2 == 0 && list[i + 1].Item2 == 1)
        {
            (list[i], list[i + 1]) = (list[i + 1], list[i]);
            i++;
        }
    }
}

for (int i = 0; i < list.Count; i++)
{
    sb.Append(list[i].Item1);
}


Console.WriteLine(sb);