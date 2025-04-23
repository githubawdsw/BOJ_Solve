// BOJ_18116


using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());

int[] par = new int[1000003];
int[] count = new int[1000003];
for (int i = 1; i <= 1000000; i++)
{
    par[i] = i;
    count[i] = 1;
}
for (int i = 0; i < n; i++)
{
    string[] inputCommand = Console.ReadLine().Split();
    string command = inputCommand[0];
    if(command == "I")
    {
        int a = int.Parse(inputCommand[1]);
        int b = int.Parse(inputCommand[2]);

        a = Find(a); b = Find(b);
        if(a != b)
        {
            par[a] = par[b];
            count[b] += count[a];
            count[a] = 0;
        }
    }
    else
    {
        int c = int.Parse(inputCommand[1]);
        sb.Append(count[Find(c)] + "\n");
    }
}

Console.WriteLine(sb);



int Find(int x)
{
    if (par[x] == x)
        return x;
    return par[x] = Find(par[x]);
}