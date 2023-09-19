//BOJ_4779


using System.Text;

StringBuilder sb = new StringBuilder();
string n = "";
char[] ans;
while (true)
{
    n = Console.ReadLine();
    if ( n == null)
        break;

    int input = Convert.ToInt32(Math.Pow(3, int.Parse(n)));
    ans = new char[input];

    for (int i = 0; i < input; i++)
        ans[i] = '-';

    recursive(0, input);

    sb.AppendLine(new string(ans));
}

Console.WriteLine(sb);


void recursive(int left, int right)
{
    if (right - left == 1)
        return;

    int length = (right - left) / 3;

    for (int i = left + length; i < right - length; i++)
        ans[i] = ' ';
    recursive(left, left + length);
    recursive(right - length, right);
}
