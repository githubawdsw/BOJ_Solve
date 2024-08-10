// BOJ_25379


int n = int.Parse(Console.ReadLine());
int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int leftSort = 0;
int rightSort = 0;
int leftCount = 0;
int rightCount = 0;
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