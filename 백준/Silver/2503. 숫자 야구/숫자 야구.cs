// BOJ_2503


int n = int.Parse(Console.ReadLine());
int[] s = new int[105];
int[] b = new int[105];
string[] number = new string[105];
int ans = 0;
for (int i = 0; i < n; i++)
{
    int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    number[i] = inputInfo[0].ToString();
    s[i] = inputInfo[1];
    b[i] = inputInfo[2];
}

for (int i = 123; i <= 987; i++)
{
    var cur = i.ToString();
    if (cur[0] == '0' || cur[1] == '0' || cur[2] == '0')
        continue;
    if (cur[0] == cur[1] || cur[1] == cur[2] || cur[2] == cur[0])
        continue;

    bool check = true;
    for (int j = 0; j < n; j++)
    {
        var num = number[j];
        int strikeCount = 0;
        int ballCount = 0;
        for (int idx = 0; idx < 3; idx++)
        {
            for (int k = 0; k < 3; k++)
            {
                if (idx == k && num[idx] == cur[k])
                {
                    strikeCount++;
                    break;
                }
                else if (num[idx] == cur[k])
                {
                    ballCount++;
                    break;
                }
            }
        }
        if (strikeCount != s[j] || ballCount != b[j])
        {
            check = false;
            break;
        }
    }
    if (check)
       ans++;
}

Console.WriteLine(ans);

