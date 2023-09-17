// BOJ_15312


List<int> dp = new List<int>();

string he = Console.ReadLine();
string she = Console.ReadLine();

string sumstr = "";
for (int i = 0; i < he.Length; i++)
{
    sumstr += he[i];
    sumstr += she[i];
}

for (int i = 0; i < sumstr.Length; i++)
{
    if (sumstr[i] == 'A' || sumstr[i] == 'E' || sumstr[i] == 'F' || sumstr[i] == 'H' || sumstr[i] == 'I')
        dp.Add(3);
    else if (sumstr[i] == 'B' || sumstr[i] == 'D' || sumstr[i] == 'G' || sumstr[i] == 'J' || sumstr[i] == 'K' ||
        sumstr[i] == 'M' || sumstr[i] == 'N' || sumstr[i] == 'P' || sumstr[i] == 'Q' || sumstr[i] == 'R' ||
        sumstr[i] == 'R' || sumstr[i] == 'T' || sumstr[i] == 'X' || sumstr[i] == 'Y')
        dp.Add(2);
    else
        dp.Add(1);
}

int length = sumstr.Length;
while (length > 2)
{
    for (int i = 0; i < length - 1; i++)
        dp[i] = (dp[i] + dp[i + 1]) % 10;
    length--;
}
Console.WriteLine($"{dp[0]}{dp[1]}");
