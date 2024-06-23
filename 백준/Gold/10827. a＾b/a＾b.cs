// BOJ_10827


using System.Numerics;

decimal[] inputab = Array.ConvertAll(Console.ReadLine().Split(), decimal.Parse);
decimal a = inputab[0];
int b = (int)inputab[1];

int point = 0;
while (a - (long)a != 0)
{
    a *= 10;
    point++;
}

BigInteger bint = (BigInteger)a;
BigInteger ans = bint;
int pos = point;
for (int i = 1; i < b; i++)
{
    ans *= bint;
    pos += point;
}

string str = ans.ToString();
while(str.Length <= pos)
{
    str = str.Insert(0, "0");
}

if(pos != 0)
    str = str.Insert(str.Length - pos, ".");

if (str.Length == pos)
    str = str.Insert(0, "0");

Console.WriteLine(str);

