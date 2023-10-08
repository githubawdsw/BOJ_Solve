// BOJ_23304

string str = Console.ReadLine();

bool check = true;
if(Akaraka(0, str.Length - 1 , str.Length , check))
    Console.WriteLine("AKARAKA");
else
    Console.WriteLine("IPSELENTI");

bool Akaraka(int start , int end , int length , bool che)
{
    if (start >= end)
        return true;
    int s = start;
    int e = end;
    while (s < e)
    {
        if (str[s] != str[e])
            return false;
        s++;
        e--;
    }
    if(length % 2 == 0)
    {
        che = (Akaraka(start, start + length / 2 - 1, length / 2, che) &&
             Akaraka(start + length / 2, end, length / 2, che));
    }
    else
    {
        che = Akaraka(start, start + length / 2 - 1, length / 2, che);
        che = Akaraka(start + length / 2 +1, end, length / 2, che);
    }
    return che;
}