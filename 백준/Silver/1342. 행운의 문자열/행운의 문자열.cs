// BOJ_1342


using System.Text;

HashSet<string> hs = new HashSet<string>();
string inputs = Console.ReadLine();
char[] storage = new char[12];
bool[] check = new bool[12];

Dfs(0);
Console.WriteLine(hs.Count);



void Dfs(int depth)
{
    if(depth == inputs.Length)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < depth; i++)
        {
            sb.Append($"{storage[i]}");
        }
        hs.Add(sb.ToString());
        return;
    }

    for (int i = 0; i < inputs.Length; i++)
    {
        if (check[i])
            continue;
        
        storage[depth] = inputs[i];
        if (depth > 0)
        {
            if (storage[depth] == storage[depth - 1])
                continue;
        }
        check[i] = true;
        Dfs(depth + 1);
        check[i] = false;
    }
}
