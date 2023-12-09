// BOJ_1107


string n = Console.ReadLine();
int m = int.Parse(Console.ReadLine());
int[] inputWrongButton = null;
if (m != 0)
    inputWrongButton = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int chanel = 100;
int arrowCount = Math.Abs(chanel - int.Parse(n));

if(m == 0)
{
    Console.WriteLine(Math.Min(n.Length , arrowCount));
    return;
}


int[] arr =  new int[10];
int ans = int.MaxValue;
dfs(0);

if(arrowCount < ans || ans < 0)
{
    Console.WriteLine(arrowCount);
    return;
}

Console.WriteLine(ans );



void dfs(int idx)
{
    if(idx <= 6 && idx > 0)
    {
        string str = "";
        for (int i = 0; i < idx; i++)
            str += arr[i].ToString();

        int value = int.Parse(str);
        ans = Math.Min(ans, Math.Abs(int.Parse(n) - value) + value.ToString().Length);
    }
    if (idx == 6)
        return;

    for (int i = 0; i < 10; i++)
    {
        if (Array.IndexOf(inputWrongButton, i) != -1)
            continue;

        arr[idx] = i;
        dfs(idx + 1);
    }
}