// BOJ_2502


using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputdk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int d = inputdk[0];
int k = inputdk[1];

int[] adp = new int[35];
int[] bdp = new int[35];
adp[1] = 1; bdp[2] = 1; adp[3] = 1; bdp[3] = 1; adp[4] = 1; bdp[4] = 2;
for (int i = 5; i <= d; i++)
{
    adp[i] = adp[i - 2] + adp[i - 1];
    bdp[i] = bdp[i - 2] + bdp[i - 1];
}

int ans = 0;
bool check = false;
for (int i = 1; i <= k; i++)
{
    for (int j = 1; j <= i; j++)
    {
        ans = j * adp[d] + i * bdp[d];
        if (ans > k)
            break;
        if(ans == k)
        {
            sb.AppendLine(j.ToString());
            sb.AppendLine($"{i}");
            check = true;
            break;
        }
    }
    if (check)
        break;
}

Console.WriteLine(sb);