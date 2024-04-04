// BOJ_15658


int n = int.Parse(Console.ReadLine());
int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] operCount = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int min = int.MaxValue;
int max = int.MinValue;

Dfs(1, inputArr[0]);

Console.WriteLine(max);
Console.WriteLine(min);


void Dfs(int depth, int sum)
{
    if(depth == n)
    {
        min = Math.Min(min, sum);
        max = Math.Max(max, sum);
        return;
    }

    if (operCount[0] > 0)
    {
        operCount[0]--;
        Dfs(depth + 1, sum + inputArr[depth]);
        operCount[0]++;
    }
    if (operCount[1] > 0)
    {
        operCount[1]--;
        Dfs(depth + 1, sum - inputArr[depth]);
        operCount[1]++;
    }
    if (operCount[2] > 0)
    {
        operCount[2]--;
        Dfs(depth + 1, sum * inputArr[depth]);
        operCount[2]++;
    }
    if (operCount[3] > 0)
    {
        operCount[3]--;
        if(sum < 0)
        {
            int temp = sum;
            temp = -temp; 
            temp /= inputArr[depth];
            temp = -temp;
            Dfs(depth + 1, temp);
        }
        else
            Dfs(depth + 1, sum / inputArr[depth]);
        operCount[3]++;
    }
}
