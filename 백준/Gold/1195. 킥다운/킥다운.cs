// BOJ_1195


string first = Console.ReadLine();
string second = Console.ReadLine();

int one = compare(first, second);
int two = compare(second , first);

Console.WriteLine(Math.Min(one,two));

int compare(string based, string move)
{
    for (int i = 0; i < based.Length; i++)
    {
        bool check = true;
        for (int j = 0; j < move.Length; j++)
        {
            if (i + j >= based.Length)
                break;

            if (based[i + j] == '2' && move[j] == '2')
            {
                check = false;
                break;
            }
        }
        if (check)
        {
            if (i + move.Length > based.Length)
                return (i + move.Length);
            else
                return (based.Length);
        }
    }
    return based.Length + move.Length;
}