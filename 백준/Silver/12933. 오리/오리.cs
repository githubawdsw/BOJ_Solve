// BOJ_12933


string cry = Console.ReadLine();
Dictionary<char, int> dict = new Dictionary<char, int>();

bool check = false;
int ans = -1;
dict['q'] = 0; dict['u'] = 0; dict['a'] = 0; dict['c'] = 0; dict['k'] = 0;
for (int i = 0; i < cry.Length; i++)
{
    var target = cry[i];
    dict[target]++;
    if (target == 'k' && dict['c'] < dict[target])
    {
        check = true;
        break;
    }
    if (target == 'c' && dict['a'] < dict[target])
    {
        check = true;
        break;
    }
    if (target == 'a' && dict['u'] < dict[target])
    {
        check = true;
        break;
    }
    if (target == 'u' && dict['q'] < dict[target])
    {
        check = true;
        break;
    }

    if(target == 'k')
    {
        int count = dict['q'];
        bool rightCount = true;
        ans = Math.Max(ans, dict['q'] - dict['k']);
        foreach (var one in dict)
        {
            if(one.Value > 0 && one.Value <= count)
                dict[one.Key]--;
            else
            {
                rightCount = false;
                break;
            }
        }
        if (!rightCount)
        {
            check = true;
            break;
        }
    }
}

int equalCount = dict['q'];
foreach (var one in dict)
{
    if (one.Value != equalCount) 
    { 
        check = true;
        break;
    }
}

if (check)
    Console.WriteLine(-1);
else
    Console.WriteLine(ans + 1);