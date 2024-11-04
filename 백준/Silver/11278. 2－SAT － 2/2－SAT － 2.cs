// BOJ_11278


using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

bool[] check = new bool[25];
List<(int, int)> list = new List<(int, int)>();
for (int i = 0; i < m; i++)
{
    int[] inputx = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    list.Add((inputx[0], inputx[1]));
}

int answer = 0;
int[] arr = new int[21];

Dfs(1);

Console.WriteLine(answer);
for (int i = 1; i <= n; i++)
{
    sb.Append(arr[i] + " ");
}
if(answer == 1)
    Console.WriteLine(sb);

void Dfs(int depth)
{
    if (answer == 1)
        return;
    if(depth == n + 1)
    {
        foreach (var one in list)
        {
            bool first = false;
            if (one.Item1 < 0)
                first = !check[-one.Item1];
            else
                first = check[one.Item1];
            
            bool second = false;
            if (one.Item2 < 0)
                second = !check[-one.Item2];
            else
                second = check[one.Item2];

            if (!first && !second)
                return;
        }

        answer = 1;
        for (int i = 1; i <= n; i++)
        {
            arr[i] = check[i] == true ? 1 : 0;
        }
        return;
    }

    check[depth] = true;
    Dfs(depth + 1);
    check[depth] = false;
    Dfs(depth + 1);
}