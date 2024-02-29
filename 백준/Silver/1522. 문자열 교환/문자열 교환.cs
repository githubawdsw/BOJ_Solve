// BOJ_1522


string str = Console.ReadLine();
int aCount = 0;

for (int i = 0; i < str.Length; i++)
{
    if (str[i] == 'a')
        aCount++;
}

string temp = str + str;
int max = 0;
for (int i = 0; i < str.Length; i++)
{
    int sum = 0;
    for (int j = i; j < i + aCount; j++)
    {
        if (temp[j] == 'a')
            sum++;
    }
    max = Math.Max(max, sum);
}

Console.WriteLine(aCount - max);
