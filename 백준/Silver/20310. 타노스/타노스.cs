// BOJ_20310


string inpuutS = Console.ReadLine();
int length = inpuutS.Length;

int zeroCount = 0;
int oneCount = 0;

for (int i = 0; i < length; i++)
{
    if (inpuutS[i] == '0')
        zeroCount++;
    else
        oneCount++;
}

zeroCount /= 2;
oneCount /= 2;

string ans = "";

for (int i = 0; i < length; i++)
{
    if (inpuutS[i] == '0' && zeroCount > 0)
    {
        ans += '0';
        zeroCount--;
    }

    else if (inpuutS[i] == '1' && oneCount > 0)
        oneCount--;

    else if (inpuutS[i] == '1' && oneCount == 0)
        ans += '1';
}

Console.WriteLine(ans);