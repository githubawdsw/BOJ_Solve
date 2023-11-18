// BOJ_2841


int[] inputnp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnp[0];
int p = inputnp[1];

Stack<int>[] sArr = new Stack<int>[6];
for (int i = 0; i < 6; i++)
    sArr[i] = new Stack<int>();

int ans = 0;
for (int i = 0; i < n; i++)
{
    int[] inputln = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int line = inputln[0];
    int num = inputln[1];

    if (sArr[line - 1].Count == 0 || sArr[line - 1].Peek() < num)
    {
        sArr[line - 1].Push(num);
        ans++;
    }
    else
    {
        while (sArr[line - 1].Count > 0 && sArr[line - 1].Peek() > num)
        {
            sArr[line - 1].Pop();
            ans++;
        }
        
        if(sArr[line - 1].Count == 0 || sArr[line - 1].Peek() < num)
        {
            sArr[line - 1].Push(num);
            ans++;
        }
    }
}

Console.WriteLine(ans);