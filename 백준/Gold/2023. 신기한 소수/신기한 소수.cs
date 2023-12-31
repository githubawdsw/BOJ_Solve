// BOJ_2023


using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
int[] usedNum = new int[10];
int[] primeNum = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };


Dfs(0);

Console.WriteLine(sb);


void Dfs(int depth)
{
	if(depth == n)
	{
        StringBuilder stringbuilder = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            stringbuilder.Append(usedNum[i]);
            if (!PrimeCheck(int.Parse(stringbuilder.ToString())))
                return;
        }

        sb.AppendLine(stringbuilder.ToString());
		return;
	}

	for (int i = 0; i < primeNum.Length; i++)
	{
		usedNum[depth] = primeNum[i];
        
        StringBuilder stringbuilder = new StringBuilder();
        for (int j = 0; j <= depth; j++)
            stringbuilder.Append(usedNum[j]);
        if (!PrimeCheck(int.Parse(stringbuilder.ToString())))
            continue;

        Dfs(depth + 1);
	}
}

bool PrimeCheck(int x)
{
    if (x == 0 || x == 1)
        return false;

    int sqrt = (int)Math.Sqrt(x);
    for (int i = 2; i <= sqrt; i++)
    {
        if (x % i == 0)
            return false;
    }
    return true;
}