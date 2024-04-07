// BOJ_1283


using System.Text;

StringBuilder sb = new StringBuilder();

int n = int.Parse(Console.ReadLine());
HashSet<char> hs = new HashSet<char>();

for (int i = 0; i < n; i++)
{
    string[] str = Console.ReadLine().Split(' ');
    bool[,] key = new bool[15, 15];

    if(CheckFirstLetter(str, key))
    {
        for (int j = 0; j < str.Length; j++)
        {
            for (int k = 0; k < str[j].Length; k++)
            {
                if (!key[j,k])
                    sb.Append($"{str[j][k]}");
                else
                {
                    sb.Append("[");
                    sb.Append($"{str[j][k]}");
                    sb.Append("]");
                }
            }
            if (j + 1 < str.Length)
                sb.Append(" ");
        }
        sb.AppendLine();
        continue;
    }

    CheckAllLetter(str, key);
    for (int j = 0; j < str.Length; j++)
    {
        for (int k = 0; k < str[j].Length; k++)
        {
            if (!key[j, k])
                sb.Append($"{str[j][k]}");
            else
            {
                sb.Append("[");
                sb.Append($"{str[j][k]}");
                sb.Append("]");
            }
        }
        if (j + 1 < str.Length)
            sb.Append(" ");
    }
    sb.AppendLine();
}

Console.WriteLine(sb);


bool CheckFirstLetter(string[] str, bool[,] key)
{
    for (int i = 0; i < str.Length; i++)
    {
        if (!hs.Contains(str[i][0]))
        {
            hs.Add(str[i][0]);
            if (str[i][0] > 90)
                hs.Add((char)(str[i][0] - 'a' + 'A'));
            else
                hs.Add((char)(str[i][0] - 'A' + 'a'));
            key[i, 0] = true;
            return true;
        }
    }
    return false;
}

void CheckAllLetter(string[] str , bool[,] key)
{
    for (int i = 0; i < str.Length; i++)
    {
        for (int j = 1; j < str[i].Length; j++)
        {
            if (!hs.Contains(str[i][j]))
            {
                hs.Add(str[i][j]);
                if (str[i][j] > 90)
                    hs.Add((char)(str[i][j] - 'a' + 'A'));
                else
                    hs.Add((char)(str[i][j] - 'A' + 'a'));
                key[i, j] = true;
                return;
            }
        }
    }
}