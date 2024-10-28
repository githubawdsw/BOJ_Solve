// BOJ_1544


using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
while (n-- > 0)
{
    int[] count = new int[30];
    bool check = true;
    string str = Console.ReadLine();
    for (int i = 0; i < str.Length; i++)
    {
        count[str[i] - 'A']++;
        if(count[str[i] - 'A'] % 4 == 3)
        {
            if (i + 1 >= str.Length || str[i] != str[i + 1])
            {
                check = false;
                break;
            }
        }
    }

    if (check)
        sb.AppendLine("OK");
    else
        sb.AppendLine("FAKE");
}


Console.WriteLine(sb);