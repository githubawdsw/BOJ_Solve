// BOJ_1268


int students = int.Parse(Console.ReadLine());

int[,] classes = new int[1005, 6];
bool[,] check = new bool[1005, 1005];
for (int i = 1; i <= students; i++)
{
    int[] classNumber = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 1; j <= 5; j++)
    {
        classes[i, j] = classNumber[j - 1];
    }
}

for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= students; j++)
    {
        for (int k = j + 1; k <= students; k++)
        {
            if (j != k && classes[j, i] == classes[k, i])
            {
                check[j, k] = true;
                check[k, j] = true;
            }
        }
    }
}

int ans = 0;
int max = 0;
for (int i = students; i > 0; i--)
{
    int count = 0;
    for (int j = 1; j <= students; j++)
    {
        if (check[i, j])
            count++;
    }
    if (max <= count)
    {
        ans = i;
        max = count;
    }
}
Console.WriteLine(ans);