// BOJ_4659


using System.Text;

StringBuilder sb = new StringBuilder();
bool[] vowel;
while (true)
{
    vowel = new bool[5];
    string str = Console.ReadLine();
    if (str == "end")
        break;
    if (ConsonantCount(0, str))
        sb.AppendLine($"<{str}> is acceptable.");
    else
        sb.AppendLine($"<{str}> is not acceptable.");

}
Console.WriteLine(sb);


bool ConsonantCount(int idx, string str)
{
    int consonantCount = 0;
    int vowelCount = 0;
    while (idx < str.Length)
    {
        if (!IsVowel(idx, str))
        {
            consonantCount++;
            vowelCount = 0;
        }
        else
        {
            consonantCount = 0;
            vowelCount++;
        }
        if (consonantCount > 2 || vowelCount > 2)
            return false;
        if (idx != 0 && str[idx] != 'e' && str[idx] != 'o' && str[idx] == str[idx - 1])
            return false;
        idx++;
    }

    for (int i = 0; i < 5; i++)
    {
        if (vowel[i])
            return true;
    }
    return false;
}

bool IsVowel(int idx, string str)
{
    if (str[idx] == 'a')
    {
        vowel[0] = true;
        return true;
    }

    if (str[idx] == 'e')
    {
        vowel[1] = true;
        return true;
    }

    if (str[idx] == 'i')
    {
        vowel[2] = true;
        return true;
    }

    if (str[idx] == 'o')
    {
        vowel[3] = true;
        return true;
    }

    if (str[idx] == 'u')
    {
        vowel[4] = true;
        return true;
    }

    return false;
}