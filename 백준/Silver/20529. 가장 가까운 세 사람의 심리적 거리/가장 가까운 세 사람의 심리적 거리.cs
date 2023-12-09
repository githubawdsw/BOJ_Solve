// BOJ_20529


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine());
    string[] inputMBTI = Console.ReadLine().Split(' ');

    int ans = int.MaxValue;
    if (n <= 32)
        for (int i = 0; i < n - 2; i++)
        {
            for (int j = i+1; j < n - 1; j++)
            {
                for (int k = j+1; k < n; k++)
                {
                    int min = 0;
                    for (int l = 0; l < 4; l++)
                    {
                        if (inputMBTI[i][l] != inputMBTI[j][l]) min++;
                        if (inputMBTI[j][l] != inputMBTI[k][l]) min++;
                        if (inputMBTI[k][l] != inputMBTI[i][l]) min++;
                    }
                    ans = Math.Min(ans, min);
                }
            }
        }
    else
        ans = 0;

    sb.AppendLine(ans.ToString());
}

Console.WriteLine(sb);

