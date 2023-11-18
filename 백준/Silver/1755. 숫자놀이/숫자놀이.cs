// BOJ_1755


using System.Text;

StringBuilder sb = new StringBuilder();

int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int m = inputnm[0];
int n = inputnm[1];

List<Tuple<string, int>> convert = new List<Tuple<string, int>>();

Dictionary<int, string> dict = new Dictionary<int, string>();
dict.Add(0, "zero");
dict.Add(1, "one");
dict.Add(2, "two");
dict.Add(3, "three");
dict.Add(4, "four");
dict.Add(5, "five");
dict.Add(6, "six");
dict.Add(7, "seven");
dict.Add(8, "eight");
dict.Add(9, "nine");

for (int i = m; i <= n; i++)
{
    if (i / 10 == 0)
        convert.Add(new Tuple<string, int>(dict[i], i));
    else
    {
        string str = i.ToString();
        string val = dict[str[0] - '0'] + dict[str[1] - '0'];
        convert.Add(new Tuple<string, int>(val, i));
    }
}
convert = convert.OrderBy(x => x.Item1).ToList();

for (int i = 0; i < convert.Count; i++)
{
    if (i % 10 == 0 && i != 0)
        sb.AppendLine();
    sb.Append($"{convert[i].Item2} ");
}

Console.WriteLine(sb);