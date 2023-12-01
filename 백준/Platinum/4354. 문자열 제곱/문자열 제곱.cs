//  BOJ_4354


using System.Text;

string s;
StringBuilder sb = new StringBuilder();

while (true)
{
    s = Console.ReadLine();
    if (s == ".")
        break;

    int[] f = failureFuc(s);
    int n = 1;
    int len = s.Length;
    while (true)
    {
        len = f[len - 1];
        if(len == 0) 
            break;
        if (s.Length % len != 0)
            continue;

        int j = 0;
        int count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != s[j])
            {
                count = 0;
                break;
            }

            j++;

            if(j == len)
            {
                j = 0;
                count++;
            }
        }
        n = Math.Max( count , n);
    }

    sb.AppendLine(n.ToString());
}
Console.WriteLine(  sb);

int[] failureFuc(string str)
{
    int[] failure = new int[str.Length];
    int j = 0;
    for (int i = 1; i < str.Length; i++)
    {
        while (j > 0 && s[i] != s[j])
            j = failure[j - 1];
        if (s[i] == s[j])
            failure[i] = ++j;
    }
    return failure;
}
