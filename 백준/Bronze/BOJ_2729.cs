//BOJ_2729

using System.Text;

StringBuilder sb = new StringBuilder();

int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    string[] inputBinary = Console.ReadLine().Split(' ');
    string x, y;
    x = inputBinary[0];
    y = inputBinary[1];
    if (y.Length > x.Length)
    {
        y = inputBinary[0];
        x= inputBinary[1];
    }
    binarySum(x , y);
}
Console.WriteLine(sb);
            

void binarySum(string x, string y)
{
    string rx = new string(x.Reverse().ToArray());
    string ry = new string(y.Reverse().ToArray());

    string ans = null;
    int carry = 0;
    for (int i = 0; i < y.Length; i++)
    {
        int sum = int.Parse(rx[i].ToString()) + int.Parse(ry[i].ToString()) + carry;
        if (sum > 1)
            carry = 1;
        else
            carry = 0;
        ans += sum % 2;
    }
    for (int i = y.Length; i < x.Length; i++)
    {
        int sum = int.Parse(rx[i].ToString()) + carry;
        if (sum > 1)
            carry = 1;
        else
            carry = 0;
        ans += sum % 2;
    }
    if (carry != 0)
    {
        ans += '1';
    }

    string ansr = new string(ans.Reverse().ToArray());

    while (ansr[0] == '0' && ansr.Length > 1)
    {
        ansr = ansr.Substring(1);
    }

    sb.AppendLine(ansr);
}