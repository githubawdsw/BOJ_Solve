// BOJ_5904



int n = int.Parse(Console.ReadLine());

int length = 3;
int midLength = 3;
while (n > length)
{
    midLength++;
    length = length * 2 + midLength;
}

while (true)
{
    int l = (length - midLength) / 2;
    if(n <= l)
    {
        midLength--;
        length = l;
    }
    else if(n > l + midLength)
    {
        n -= l + midLength;
        midLength--;
        length = l;
    }
    else
    {
        n -= l;
        break;
    }

}

if(n == 1)
    Console.WriteLine("m");
else
    Console.WriteLine("o");