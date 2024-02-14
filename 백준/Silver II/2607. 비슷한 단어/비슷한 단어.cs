// BOJ_2607


int n = int.Parse(Console.ReadLine());
int[] firstCount = new int[30];
int length = 0;
int ans = 0;
for (int i = 0; i < n; i++)
{
    string str = Console.ReadLine();
    int[] targetCount = new int[30];
    int wordCount = 0;
    int diffCount = 0;

    if(i == 0)
    {
        length = str.Length;
        for (int j = 0; j < length; j++)
        {
            firstCount[str[j] - 'A']++;
        }
        continue;
    }
    else
    {
        for (int j = 0; j < str.Length; j++)
        {
            targetCount[str[j] - 'A']++;
        }
        for (int j = 0; j < firstCount.Length; j++)
        {
            if (firstCount[j] != targetCount[j])
                wordCount++;
            diffCount += Math.Abs(firstCount[j] - targetCount[j]);
        }
    }
    if (diffCount <= 1)
    {
        ans++;
    }
    else if (diffCount == 2 && length == str.Length)
    {
        ans++;
    }
}

Console.WriteLine(ans);