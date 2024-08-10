// BOJ_25379


int n = int.Parse(Console.ReadLine());
int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

long leftSort = 0;
long rightSort = 0;
long leftCount = 0;
long rightCount = 0;
for (int i = 0; i < n; i++)
{
    if (inputArr[i] % 2 == 0)
    {
        leftSort++;
        leftCount += rightSort;
    }
    else
    {
        rightSort++;
        rightCount += leftSort;
    }
}

Console.WriteLine(Math.Min(leftCount, rightCount));
