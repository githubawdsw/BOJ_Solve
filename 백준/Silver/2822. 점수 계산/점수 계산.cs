// BOJ_2822


using System.Text;

StringBuilder sb = new StringBuilder();
List<int> pointList = new List<int>();
for (int i = 0; i < 8; i++)
    pointList.Add(int.Parse(Console.ReadLine()));

List<int> sortList = new List<int>(pointList);
sortList.Sort();
int sum = 0;
List<int> num = new List<int>();
for (int i = 3; i < 8; i++)
{
    sum += sortList[i];
    for (int j = 0; j < 8; j++)
    {
        if (sortList[i] == pointList[j])
            num.Add(j + 1);
    }
}
num.Sort();

sb.AppendLine(sum.ToString());
for (int i = 0; i < 5; i++)
    sb.Append($"{num[i]} ");

Console.WriteLine(sb);
