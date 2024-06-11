// BOJ_10597


using System.Text;

string str = Console.ReadLine();
bool[] check = new bool[55];
int[] arr = new int[55];
List<string> list = new List<string>();

Dfs(0,0);

Console.WriteLine(list[0]);


void Dfs(int stridx, int arridx)
{
    if (list.Count > 0)
        return;

    if (stridx >= str.Length)
    {
        int i = 1;
        StringBuilder sb = new StringBuilder();
        while (check[i])
        {
            sb.Append(arr[i - 1] + " ");
            i++;
        }
        if(i == arridx + 1)
            list.Add(sb.ToString());

        return;
    }

    if (!check[str[stridx] - '0'])
    {
        check[str[stridx] - '0'] = true;
        arr[arridx] = str[stridx] - '0';
        Dfs(stridx + 1, arridx + 1);
        check[str[stridx] - '0'] = false;
    }

    if(stridx < str.Length - 1) 
    { 
        int value = (str[stridx] - '0') * 10 + str[stridx + 1] - '0';
        if (value > 50)
            return;

        if (!check[value])
        {
            check[value] = true;
            arr[arridx] = value;
            Dfs(stridx + 2, arridx + 1);
            check[value] = false;
        }
    }
}