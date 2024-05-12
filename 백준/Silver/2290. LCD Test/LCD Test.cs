// BOJ_2290


using System.Text;

StringBuilder sb = new StringBuilder();
string[] inputnk = Console.ReadLine().Split(' ');
int s = int.Parse(inputnk[0]);
string strn = inputnk[1];
long n = long.Parse(strn);


for (int i = 1; i <= (2 * s) + 3; i++)
{
    for (int j = 0; j < strn.Length; j++)
    {
        if (i == 1)
        {
            if (strn[j] == '1' || strn[j] == '4')
            {
                sb.Append(' ');
                for (int k = 0; k < s; k++)
                {
                    sb.Append(' ');
                }
                sb.Append(' ');
            }
            else
            {
                sb.Append(' ');
                for (int k = 0; k < s; k++)
                {
                    sb.Append('-');
                }
                sb.Append(' ');
            }
        }
        else if (i > 1 && i < s + 2)
        {
            if (strn[j] == '1' || strn[j] == '2' || strn[j] == '3' || strn[j] == '7')
            {
                sb.Append(' ');
                for (int k = 0; k < s; k++)
                {
                    sb.Append(' ');
                }
                sb.Append('|');
            }
            else if (strn[j] == '5' || strn[j] == '6')
            {
                sb.Append('|');
                for (int k = 0; k < s; k++)
                {
                    sb.Append(' ');
                }
                sb.Append(' ');
            }
            else
            {
                sb.Append('|');
                for (int k = 0; k < s; k++)
                {
                    sb.Append(' ');
                }
                sb.Append('|');
            }
        }
        else if (i == s + 2)
        {
            if (strn[j] == '1' || strn[j] == '7' || strn[j] == '0')
            {
                sb.Append(' ');
                for (int k = 0; k < s; k++)
                {
                    sb.Append(' ');
                }
                sb.Append(' ');
            }
            else
            {
                sb.Append(' ');
                for (int k = 0; k < s; k++)
                {
                    sb.Append('-');
                }
                sb.Append(' ');
            }
        }
        else if (i > s + 2 && i < (2 * s + 3))
        {
            if (strn[j] == '2')
            {
                sb.Append('|');
                for (int k = 0; k < s; k++)
                {
                    sb.Append(' ');
                }
                sb.Append(' ');
            }
            else if (strn[j] == '6' || strn[j] == '8' || strn[j] == '0')
            {
                sb.Append('|');
                for (int k = 0; k < s; k++)
                {
                    sb.Append(' ');
                }
                sb.Append('|');
            }
            else
            {
                sb.Append(' ');
                for (int k = 0; k < s; k++)
                {
                    sb.Append(' ');
                }
                sb.Append('|');
            }
        }
        else
        {
            if (strn[j] == '1' || strn[j] == '4' || strn[j] == '7')
            {
                sb.Append(' ');
                for (int k = 0; k < s; k++)
                {
                    sb.Append(' ');
                }
                sb.Append(' ');
            }
            else
            {
                sb.Append(' ');
                for (int k = 0; k < s; k++)
                {
                    sb.Append('-');
                }
                sb.Append(' ');
            }
        }
        sb.Append(' ');
    }
    sb.AppendLine();
}

Console.WriteLine(sb);