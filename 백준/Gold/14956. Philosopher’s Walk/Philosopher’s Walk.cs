// BOJ_14956


string[] inputnm = Console.ReadLine().Split(' ');
int n = int.Parse(inputnm[0]);
int m = int.Parse(inputnm[1]);
KeyValuePair<int, int> ans = philo(n, m);
Console.WriteLine($"{ans.Key} {ans.Value}");

KeyValuePair<int, int> philo(int len, int walk)
{
    if (len == 2)
    {
        switch (walk)
        {
            case 1:
                return new KeyValuePair<int, int>(1, 1);
            case 2:
                return new KeyValuePair<int, int>(1, 2);
            case 3:
                return new KeyValuePair<int, int>(2, 2);
            case 4:
                return new KeyValuePair<int, int>(2, 1);
        }
    }
    int half = len / 2;
    int section = half * half;
    if (walk <= section)
    {
        KeyValuePair<int, int> temp = philo(half, walk);
        return new KeyValuePair<int, int>(temp.Value, temp.Key);
    }
    else if (walk <= section * 2)
    {
        KeyValuePair<int, int> temp = philo(half, walk - section);
        return new KeyValuePair<int, int>(temp.Key, temp.Value + half);
    }
    else if (walk <= section * 3)
    {
        KeyValuePair<int, int> temp = philo(half, walk - section * 2);
        return new KeyValuePair<int, int>(temp.Key + half, temp.Value + half); ;
    }
    else
    {
        KeyValuePair<int, int> temp = philo(half, walk - section * 3);
        return new KeyValuePair<int, int>(2 * half - temp.Value + 1, half - temp.Key + 1);
    }
}