// BOJ_9081


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    string str = Console.ReadLine();

    char[] ans = str.ToCharArray();
    int left = str.Length - 1;
    while (left > 0 && str[left - 1] - 'A' >= str[left] - 'A')
    {
        left--;
    }

    if(left == 0)
    {
        sb.AppendLine(str);
        continue;
    }

    int right = str.Length - 1;
    while (str[left - 1] - 'A' >= str[right] - 'A')
    {
        right--;
    }

    (ans[left - 1], ans[right]) = (str[right], str[left - 1]);

    right = str.Length - 1;
    while (left < right)
    {
        (ans[left], ans[right]) = (ans[right], ans[left]);
        left++;
        right--;
    }

    sb.AppendLine(new string(ans));
}

Console.WriteLine(sb);