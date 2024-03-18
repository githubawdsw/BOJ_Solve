// BOJ_4375



using System.Text;

StringBuilder sb = new StringBuilder();
while (true)
{
    string input = Console.ReadLine();
    if (input == "" || input == null)
        break;

    int value = int.Parse(input);
    if (value == 1)
    {
        sb.AppendLine(1.ToString());
        continue;
    }

    int before = 1 % value;
    for (int i = 2; i <= value; i++)
    {
        before = (before * 10 + 1) % value;
        if (before == 0)
        {
            sb.AppendLine(i.ToString());
            break;
        }
    }
}

Console.WriteLine(sb);