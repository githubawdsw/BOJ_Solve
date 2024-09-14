// BOJ_3568


using System.Text;

StringBuilder sb= new StringBuilder();

string[] inputstr = Console.ReadLine().Split(' ');

List<string> list = new List<string>();
for (int i = 1; i < inputstr.Length; i++)
{
    string temp = "";
    string name = "";
    for (int j = 0; j < inputstr[i].Length; j++)
    {
        if (inputstr[i][j] == ';' || inputstr[i][j] == ',' || inputstr[i][j] == '[')
            continue;
        if (inputstr[i][j] - 'A' < 0 || inputstr[i][j] == ']')
        {
            temp += inputstr[i][j];
            if (inputstr[i][j] == ']')
                temp += '[';
        }
        else
            name += inputstr[i][j];
    }
    list.Add(new string(temp.Reverse().ToArray()) + ' ' + name);
}

for (int i = 0; i < list.Count; i++)
{
    sb.AppendLine(inputstr[0] + list[i] + ';');
}

Console.WriteLine(sb);