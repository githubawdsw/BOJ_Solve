// BOJ_24268


int[] inputnd = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnd[0];
int d = inputnd[1];

while (n <= 1000000000)
{
    int[] count = new int[10];
    n += 1;
    int temp = n;
    bool countCheck = true;
    int counting = 0;
    while (temp > 0)
    {
        int num = temp % d;
        count[num]++;
        if (count[num] > 1)
        {
            countCheck = false;
        }
        temp /= d;
        counting++;
    }

    if (countCheck)
    {
        bool emptyCehck = false;
        for (int i = 0; i < d; i++)
        {
            if (count[i] == 0)
            {
                emptyCehck = true;
                break;
            }
        }
        if (emptyCehck)
            continue;

        break;
    }

    if (counting > d)
    {
        Console.WriteLine(-1);
        return;
    }
    else if (counting != d)
        n += d - 1;
}

Console.WriteLine(n);