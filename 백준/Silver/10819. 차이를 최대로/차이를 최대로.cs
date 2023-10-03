// BOJ_10819

int[] indexArr = new int[10];
bool[] check = new bool[10];
int n = int.Parse(Console.ReadLine());
string[] inputArr = Console.ReadLine().Split(' ');

int ans = 0;
backtracking(0);

Console.WriteLine(  ans);


void backtracking(int count)
{
    if(count == n)
    {
        int temp = 0;
        for (int i = 1; i < n; i++)
            temp += Math.Abs( indexArr[i - 1] - indexArr[i]);
        ans = Math.Max(ans, temp);
        return;
    }

    for (int i = 0; i < n; i++)
    {
        if (check[i])
            continue;
        check[i] = true;
        indexArr[count] = int.Parse(inputArr[i]);
        backtracking(count + 1);
        check[i] = false;

    }
}