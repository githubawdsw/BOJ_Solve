// BOJ_9996


using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
string str = Console.ReadLine();
for (int i = 0; i < n; i++)
{
    string s = Console.ReadLine();
    int left = 0;
    bool check = false;
    while (str[left] != '*')
    {
        if (s[left] != str[left])
        {
            check = true;
            break;
        }
        left++;
    }
    if(check)
    {
        sb.AppendLine("NE");
        continue;
    }
    int right = s.Length - 1;
    int compare = str.Length - 1;
    while (str[compare] != '*')
    {
        if (s[right--] != str[compare--])
        {
            check = true;
            break;
        }
    }
    if (check)
    {
        sb.AppendLine("NE");
        continue;
    }
    if(left > right && left - right != 1)
    {
        sb.AppendLine("NE");
        continue;
    }
    sb.AppendLine("DA");
}

Console.WriteLine(  sb);