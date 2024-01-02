// BOJ_2529


using System.Text;

int k = int.Parse(Console.ReadLine());
string inputinfo = Console.ReadLine().Replace(" ", "");
int[] storage = new int[10];
bool[] check = new bool[10];
SortedSet<string> ss = new SortedSet<string>();

Array.Fill(storage, -1);
for (int i = 0; i < 10; i++)
{
    check[i] = true;
    storage[0] = i;
    Dfs(0, i);
    check[i] = false;
}

Console.WriteLine(ss.Last());
Console.WriteLine(ss.First());

void Dfs(int depth ,int number)
{
    if(depth == k)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < depth + 1; i++)
        {
            sb.Append($"{storage[i]}");
        }
        ss.Add(sb.ToString());
        return;
    }

    for (int i = 0; i < 10; i++)
    {
        if (i == number || check[i])
            continue;

        if (inputinfo[depth] == '<')
        {
            if(number < i)
            {
                check[i] = true;
                storage[depth + 1] = i;
                Dfs(depth + 1, i);
                check[i] = false;
            }
        }
        else
        {
            if (number > i)
            {
                check[i] = true;
                storage[depth + 1] = i;
                Dfs(depth + 1, i);
                check[i] = false;
            }
        }
    }
}