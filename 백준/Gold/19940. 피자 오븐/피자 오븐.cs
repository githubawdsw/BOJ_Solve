// BOJ_19940


using System.Text;

StringBuilder sb = new StringBuilder();

int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine());

    int value = n % 60;
    int addh = n / 60;
    int addt = 0;
    int mint = 0;
    int addo = 0;
    int mino = 0;
    bool sign = true;

    if(value <= 35)
    {
        addt = value / 10;
        value %= 10;
    }
    else
    {
        mint = (60 - value) / 10;
        value = (60 - value) % 10;
        addh++;
        sign = false;
    }

    if(sign)
    {
        if (value > 5)
        {
            addt++;
            mino = 10 - value;
        }
        else
            addo = value;
    }
    else
    {
        if (value > 5)
        {
            mint++;
            addo = 10 - value;
        }
        else
            mino = value;
    }
    sb.AppendLine($"{addh} {addt} {mint} {addo} {mino}");
}

Console.WriteLine(sb);