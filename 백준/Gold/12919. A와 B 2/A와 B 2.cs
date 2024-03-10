// BOJ_12919


using System.Runtime.ConstrainedExecution;
using System.Text;

string s = Console.ReadLine();
string t = Console.ReadLine();

int ans = 0;

int length = t.Length;
CheckA(t, length);
CheckB(t, length);


Console.WriteLine(ans);


void CheckA(string str, int l)
{
    if (l == s.Length)
    {
        bool check = true;
        for (int i = 0; i < l; i++)
        {
            if (s[i] != str[i])
                check = false;
        }
        if (check)
            ans = 1;
        return;
    }

    if (str[l - 1] != 'A' || ans == 1)
        return;

    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < l - 1; i++)
    {
        sb.Append(str[i]);
    }
    CheckA(sb.ToString(), l - 1);
    CheckB(sb.ToString(), l - 1);
}
void CheckB(string str, int l)
{
    if(l == s.Length)
    {
        bool check = true;
        for (int i = 0; i < l; i++)
        {
            if (s[i] != str[i])
                check = false;
        }
        if (check)
            ans = 1;
        return;
    }

    if (str[0] != 'B' || ans == 1)
        return;

    StringBuilder sb = new StringBuilder();
    for (int i = str.Length - 1; i >= 1; i--)
    {
        sb.Append(str[i]);
    }

    CheckA(sb.ToString(), l - 1);
    CheckB(sb.ToString(), l - 1);
}