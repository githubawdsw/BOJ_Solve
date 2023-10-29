// BOJ_3107


string inputstr = Console.ReadLine();

string[] str = inputstr.Split(':');
int count = str.Length;
bool check0 = false;
bool check8 = false;
for (int i = 0; i < str.Length; i++)
{
    string temp = "";
    if (str[i] == temp)
    {
        if (str.Length > 8)
        {
            if(i == 0)
                check0 = true;
            else if(i == 8)
                check8 = true;
        }
        str[i] = "0000";
        while (7 >= count )
        {
            str[i] += ":0000";
            count++;
        }
    }
    else
    {
        if (str[i].Length < 4)
            for (int j = 0; j < 4 - str[i].Length; j++)
                temp += 0;
        temp += str[i];
        str[i] = temp;
    }
}
string ans = "";
for (int i = 0; i < str.Length - 1; i++)
{
    if (str.Length > 8)
    {
        if ((i == 0 &&check0) || (check8 && i == 7))
            continue;
    }
    ans += str[i] + ":";
}
ans += str[str.Length - 1];
Console.WriteLine(  ans);

