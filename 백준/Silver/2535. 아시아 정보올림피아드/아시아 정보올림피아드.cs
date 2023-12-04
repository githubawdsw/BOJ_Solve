// BOJ_2535


using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());

int[] countryArr = new int[105];
List<Tuple<int, int, int>> list = new List<Tuple<int, int, int>>();
for (int i = 0; i < n; i++)
{
    int[] inputcsg = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int country = inputcsg[0];
    int student = inputcsg[1];
    int grade = inputcsg[2];

    list.Add(new(country, student, grade));
}

int count = 0;
list = list.OrderByDescending(x => x.Item3).ToList();
for (int i = 0; i < n; i++)
{
    if (countryArr[list[i].Item1] < 2)
    {
        sb.AppendLine($"{list[i].Item1} {list[i].Item2}");
        countryArr[list[i].Item1]++;
        count++;
    }
    if (count == 3)
        break;
}

Console.WriteLine(sb);

