// BOJ_2138


int n = int.Parse(Console.ReadLine());

string str = Console.ReadLine();
string target = Console.ReadLine();
int[] inputA = new int[100005];
int[] inputB = new int[100005];
for (int i = 0; i < n; i++)
{
    inputA[i] = str[i] - '0';
    inputB[i] = target[i] - '0';
}

int ans = Change(0);
inputA[0] = Math.Abs(inputA[0] - 1);
inputA[1] = Math.Abs(inputA[1] - 1);
int PressFirst = Change(0);

ans = Math.Min(ans, PressFirst + 1);

if(ans == 100005)
    Console.WriteLine(-1);
else
    Console.WriteLine(ans);


int Change(int press)
{
    int[] copyA = new int[inputA.Length];
    inputA.CopyTo(copyA, 0);
    int[] copyB = (int[])inputB.Clone();

    for (int i = 1; i < n; i++)
    {
        if (copyA[i - 1] == copyB[i - 1])
            continue;

        press++;
        for (int j = i - 1; j <= i + 1; j++)
        {
            if(j < n)
                copyA[j] = Math.Abs(copyA[j] - 1);
        }
    }

    bool check = true;
    for (int i = 0; i < n; i++)
    {
        if (copyA[i] != inputB[i])
            check = false;
    }
    if (check)
        return press;

    return 100005;
}