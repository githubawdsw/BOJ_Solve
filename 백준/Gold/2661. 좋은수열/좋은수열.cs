// BOJ_2661


int n = int.Parse(Console.ReadLine());
bool isFind = false;
DFS(1, "1");


void DFS(int depth, string str)
{
    if (isFind)
        return;

    int length = str.Length;
    for (int i = 1; i <= length / 2; i++)
    {
        if(str.Substring(length - i, i) == str.Substring(length - (2* i), i))
            return;
    }

    if(depth == n)
    {
        isFind = true;
        Console.WriteLine( str );
        return;
    }

    else
    {
        for (int i = 0; i < n; i++)
        {
            DFS(depth + 1, str + "1");
            DFS(depth + 1, str + "2");
            DFS(depth + 1, str + "3");
        }
    }
}
