// BOJ_1037



int m = int.Parse(Console.ReadLine());
string[] inputarr = Console.ReadLine().Split(' ');
List<int> list = new List<int>();
for (int i = 0; i < m; i++)
    list.Add(int.Parse(inputarr[i]));

list.Sort();
int ans = 0;
if (m % 2 == 1)
{
    ans = list[m / 2];
    ans *= ans;
}
else
    ans = list[0] * list.Last();

Console.WriteLine(  ans);

