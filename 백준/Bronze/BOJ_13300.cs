// BOJ_13300


string[] inputnk = Console.ReadLine().Split(' ');
int n = int.Parse(inputnk[0]);
int k = int.Parse(inputnk[1]);
int[,] student = new int[2, 7];
while (n-- > 0)
{
    string[] inputStudent = Console.ReadLine().Split(' ');
    student[int.Parse(inputStudent[0]), int.Parse(inputStudent[1])]++;
}

int ans = 0;
for (int i = 1; i <= 6; i++)
{
    if (student[0, i] % k == 0)
        ans += student[0, i] / k;
    else
        ans += student[0, i] / k +1;
    if (student[1, i] % k == 0)
        ans += student[1, i] / k;
    else
        ans += student[1, i] / k + 1;
}
Console.WriteLine(ans);
