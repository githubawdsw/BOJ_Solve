// BOJ_25965

using System.Text;

long n, m, k, d, a = 0;
long[]  SumAmount = new long [3];
string[] kda = new string[3];
StringBuilder sr = new StringBuilder();
n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    m = int.Parse(Console.ReadLine());
    string[,] mission = new string[m, 3];
    for (int j = 0; j < m; j++)
    {
        string[] amount = Console.ReadLine().Split(" ");
        mission[j, 0] = amount[0];
        mission[j, 1] = amount[1];
        mission[j, 2] = amount[2];
    }

    kda = Console.ReadLine().Split(" ");

    sum(mission);

    sr.AppendLine((SumAmount[0] - SumAmount[1] + SumAmount[2]).ToString());
    SumAmount[0] = 0;
    SumAmount[1] = 0;
    SumAmount[2] = 0;
}

            
Console.Write(sr);

void sum(string[,] _mission)
{
    for (int i = 0; i < m; i++)
    {
        k = long.Parse(_mission[i, 0]) * long.Parse(kda[0]);
        d = long.Parse(_mission[i, 1]) * long.Parse(kda[1]);
        a = long.Parse(_mission[i, 2]) * long.Parse(kda[2]);
        if (k - d + a < 0)
            continue;
        SumAmount[0] += k;
        SumAmount[1] += d;
        SumAmount[2] += a;
    }
}
