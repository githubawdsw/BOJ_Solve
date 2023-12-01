//  BOJ_11585



int n = int.Parse(Console.ReadLine());
string inputdefault = Console.ReadLine();
string inputstr = Console.ReadLine();
inputstr = inputstr.Replace(" ", "");

int[] failure = FailFuc(inputstr);

inputdefault = inputdefault.Replace(" ", "");
string arr = inputdefault + inputdefault;
arr = arr.Substring(0, arr.Length - 1);

int j = 0;
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    while (j > 0 && arr[i] != inputstr[j])
        j = failure[j - 1];
    if (arr[i] == inputstr[j])
        j++;
    if (j == failure.Length)
    {
        count++;
        j = failure[j - 1];
    }
}

int gcd = GCD(count, n);
Console.WriteLine($"{count / gcd}/{n / gcd}");

int GCD(int a, int b)
{
    if (b == 0)
        return a;
    return GCD(b, a % b);
}

int[] FailFuc(string str)
{
    int[] fail = new int[str.Length];
    int j = 0;
    for (int i = 1; i < str.Length; i++)
    {
        while (j > 0 && str[i] != str[j])
            j = fail[j - 1];
        if (str[i] == str[j])
            fail[i] = ++j;
    }
    return fail;
}