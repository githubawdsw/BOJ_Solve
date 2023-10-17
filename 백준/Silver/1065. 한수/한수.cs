// BOJ_1065



string inputn = Console.ReadLine();
int n = int.Parse(inputn);
if( n < 100)
{
    Console.WriteLine( n );
    return;
}

int count = 99;
for (int i = 100; i <= n; i++)
{
    string str = i.ToString();
    int diff = (str[0] - '0') - (str[1] - '0');
    int val = str[1] - '0';
    bool check = true;
    for (int j = 2; j < str.Length; j++)
    {
        if (diff != val - (str[j] - '0'))
        {
            check = false;
            break;
        }
    }
    if (check)
        count++;
}

Console.WriteLine(  count );
