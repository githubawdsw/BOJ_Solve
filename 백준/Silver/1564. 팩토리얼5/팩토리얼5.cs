// BOJ_1564


int n = int.Parse(Console.ReadLine());

long factorial = 1;
bool check = false;
for (int i = 1; i <= n; i++)
{
    factorial *= i;
    while (factorial % 10 == 0)
        factorial /= 10;

    if(factorial >= 100000)
        check = true;

    factorial %= 1000000000000;
}

factorial %= 100000;
string str = factorial.ToString();
int length = str.Length;
string ans = "";
while (length < 5 && check)
{
    ans += "0";
    length++;
}

ans += str;
Console.WriteLine(ans);