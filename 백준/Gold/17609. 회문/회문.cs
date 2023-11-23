// BOJ_17609


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    string str = Console.ReadLine();

    int left = 0;
    int right = str.Length - 1;
    int count = 0;
    while (left <= right)
    {
        if (str[left] == str[right])
        {
            left++;
            right--;
        }
        else
        {
            string temp1 = str.Substring(left, right - left);
            string temp2 = str.Substring(left + 1, right - left);
            if (check(temp1))
                right--;
            else if (check(temp2))
                left++;
            count++;
        }
        if(count > 1)
            break;
    }
    if (count == 0)
        sb.AppendLine("0");
    else if (count == 1)
        sb.AppendLine("1");
    else
        sb.AppendLine("2");
}

Console.WriteLine(sb);


bool check(string s)
{
    string rev = new string(s.Reverse().ToArray());
    return s == rev;
}