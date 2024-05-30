// BOJ_2621



List<int> cardNumList = new List<int>();
Dictionary<char, int> dict = new Dictionary<char, int>();
int[] cardCountArr = new int[10];
dict.Add('R', 0); dict.Add('B', 0); dict.Add('Y', 0); dict.Add('G', 0);

for (int i = 0; i < 5; i++)
{
    string[] inputInfo = Console.ReadLine().Split();
    char color = char.Parse(inputInfo[0]);
    int number = int.Parse(inputInfo[1]);
    cardNumList.Add(number);
    dict[color]++;
    cardCountArr[number]++;
}

cardNumList.Sort();
int ans = 0;

if (StraightFlush())
{
    ans += 900;
    ans += cardNumList.Last();
}
else if (FourCard())
{
    ans += 800;
    for (int i = 0; i < 10; i++)
    {
        if (cardCountArr[i] == 4)
            ans += i;
    }
}
else if (FullHouse())
{
    ans += 700;

    for (int i = 0; i < 10; i++)
    {
        if (cardCountArr[i] == 3)
            ans += i * 10;

        if (cardCountArr[i] == 2)
            ans += i;
    }
}
else if (Flush())
{
    ans += 600;
    ans += cardNumList.Last();
}
else if (Straight())
{
    ans += 500;
    ans += cardNumList.Last();
}
else if (Triple())
{
    ans += 400;
    for (int i = 0; i < 10; i++)
    {
        if (cardCountArr[i] == 3)
            ans += i;
    }
}
else if (TwoPair())
{
    int max = 0;
    int min = 100;
    for (int i = 0; i < 10; i++)
    {
        if (cardCountArr[i] == 2)
        {
            max = Math.Max(max, i);
            min = Math.Min(min, i);
        }
    }
    ans += (max * 10) + min + 300;
}
else if (OnePair())
{
    ans += 200;
    for (int i = 0; i < 10; i++)
    {
        if (cardCountArr[i] == 2)
            ans += i;
    }
}
else
{
    ans += cardNumList.Last() + 100;
}

Console.WriteLine(ans);



bool StraightFlush()
{
    if(Straight() && Flush())
        return true;

    return false;
}

bool FourCard()
{
    for (int i = 0; i < 10; i++)
    {
        if (cardCountArr[i] == 4)
            return true;
    }
    return false;
}

bool FullHouse()
{
    bool checkThree = false;
    bool checkTwo = false;
    for (int i = 0; i < 10; i++)
    {
        if (cardCountArr[i] == 3)
            checkThree = true;

        if (cardCountArr[i] == 2)
            checkTwo = true;
    }

    if (checkThree && checkTwo)
        return true;

    return false;
}

bool Flush()
{
    foreach (var one in dict)
    {
        if (one.Value == 5)
            return true;
    }
    return false;
}

bool Straight()
{
    int min = cardNumList[0];
    for (int i = min; i < min + 5; i++)
    {
        if (cardNumList[i - min] != i)
            return false;
    }
    return true;
}

bool Triple()
{
    for (int i = 0; i < 10; i++)
    {
        if (cardCountArr[i] == 3)
            return true;
    }
    return false;
}

bool TwoPair()
{
    int count = 0;
    for (int i = 0; i < 10; i++)
    {
        if (cardCountArr[i] == 2)
            count++;
    }
    if (count == 2)
        return true;

    return false;
}
bool OnePair()
{
    for (int i = 0; i < 10; i++)
    {
        if (cardCountArr[i] == 2)
            return true;
    }
    return false;
}
