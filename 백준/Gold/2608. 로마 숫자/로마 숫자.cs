// BOJ_2608


string str1 = Console.ReadLine();
string str2 = Console.ReadLine();

Dictionary<char, int> dict = new Dictionary<char, int>
{
    {'I', 1} , {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}
};

int sum = Calculator(str1) + Calculator(str2);
Console.WriteLine(sum);

string ans = Texting(sum);
Console.WriteLine(ans);


int Calculator(string str)
{
    int target = 0;
    int after = 1;
    int sum = 0;
    while (target < str.Length)
    {
        if(after != str.Length)
        {
            if (dict[str[target]] < dict[str[after]])
            {
                sum += dict[str[after]] - dict[str[target]];
                target++;
                after++;
            }
            else
            {
                sum += dict[str[target]];
            }
        }
        else
        {
            sum += dict[str[target]];
        }
        target++;
        after++;
    }
    return sum;
}

string Texting(int x)
{
    string str = x.ToString();
    int length = str.Length;
    string ans = "";
    for (int i = 0; i < length; i++)
    {
        int idx = length - 1 - i;
        if(idx == 3)
        {
            if (str[i] < '4')
            {
                for (int j = 0; j < str[i] - '0'; j++)
                {
                    ans += 'M';
                }
            }
        }
        else if (idx == 2)
        {
            if (str[i] < '4')
            {
                for (int j = 0; j < str[i] - '0'; j++)
                {
                    ans += 'C';
                }
            }
            else if (str[i] == '4')
            {
                ans += 'C';
                ans += 'D';
            }
            else if (str[i] < '9')
            {
                ans += 'D';
                for (int j = 5; j < str[i] - '0'; j++)
                {
                    ans += 'C';
                }
            }
            else
            {
                ans += 'C';
                ans += 'M';
            }
        }
        else if (idx == 1)
        {
            if (str[i] < '4')
            {
                for (int j = 0; j < str[i] - '0'; j++)
                {
                    ans += 'X';
                }
            }
            else if (str[i] == '4')
            {
                ans += 'X';
                ans += 'L';
            }
            else if (str[i] < '9')
            {
                ans += 'L';
                for (int j = 5; j < str[i] - '0'; j++)
                {
                    ans += 'X';
                }
            }
            else
            {
                ans += 'X';
                ans += 'C';
            }
        }
        else
        {
            if (str[i] < '4')
            {
                for (int j = 0; j < str[i] - '0'; j++)
                {
                    ans += 'I';
                }
            }
            else if (str[i] == '4')
            {
                ans += 'I';
                ans += 'V';
            }
            else if (str[i] < '9')
            {
                ans += 'V';
                for (int j = 5; j < str[i] - '0'; j++)
                {
                    ans += 'I';
                }
            }
            else
            {
                ans += 'I';
                ans += 'X';
            }
        }
    }
    return ans;
}
