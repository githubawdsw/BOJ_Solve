// BOJ_2635


using System.Text;

StringBuilder sb = new StringBuilder();
int input = int.Parse(Console.ReadLine());
int count = 0;
List<int> ansList = new List<int>();

for (int i = 0; i < input; i++)
{
    int first = input;
    int second = input - i;

    List<int> list = new List<int>
    {
        first, second
    };

    while (first - second >= 0)
    {
        list.Add(first - second);
        (first, second) = (second, first - second);
    }

    if(count <= list.Count)
    {
        ansList = list.ToList();
        count = list.Count;
    }
    else
        break;
    
}

sb.AppendLine(count.ToString());
for (int i = 0; i < count; i++)
{
    sb.Append($"{ansList[i]} ");
}

Console.WriteLine(sb);