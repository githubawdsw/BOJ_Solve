// BOJ_20164


string n = Console.ReadLine();

int min = int.MaxValue;
int max = 0;

int sum = 0;
for (int i = 0; i < n.Length; i++)
{
    if ((n[i] - '0') % 2 == 1)
        sum++;
}

Solve(n, sum);

Console.WriteLine($"{min} {max}");



void Solve(string str, int sum)
{

    if(str.Length == 1)
    {
        min = Math.Min(min, sum);
        max = Math.Max(max, sum);

        return;
    }

    else if(str.Length == 2)
    {
        int value = str[0] - '0' + str[1] - '0';
        string temp = value.ToString();

        for (int i = 0; i < temp.Length; i++)
        {
            if ((temp[i] - '0') % 2 == 1)
                sum++;
        }
        Solve(temp, sum);
    }

    else
    {
        int len = str.Length;
        for (int left = 0; left < len - 2; left++)
        {
            int right = len - 1;
            while (right - left > 1)
            {
                int value = 0;
                int count = 0;
                value += int.Parse(str.Substring(0, left + 1));
                value += int.Parse(str.Substring(left + 1, right - left - 1));
                value += int.Parse(str.Substring(right, len - right));

                string temp = value.ToString();

                for (int i = 0; i < temp.Length; i++)
                {
                    if ((temp[i] - '0') % 2 == 1)
                        count++;
                }
                Solve(temp, sum + count);
                right--;
            }
            
        }
    }
}
