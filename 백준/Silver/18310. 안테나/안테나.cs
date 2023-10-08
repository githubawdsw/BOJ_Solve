// BOJ_18310


int n = int.Parse(Console.ReadLine());
string[] inputarr =Console.ReadLine().Split(' ');

List<int> list = new List<int>();
for (int i = 0; i < n; i++)
    list.Add(int.Parse(inputarr[i]));
list.Sort();

if(n %2 == 1)
{
    Console.WriteLine(list[n / 2]);
    return;
}
else
{
    int mid1 = list[n / 2 - 1];
    int mid2 = list[n / 2];
    int left = 0, right = 0;
    for (int i = 0; i < n; i++)
    {
        left += Math.Abs(list[i] - mid1);
        right += Math.Abs(list[i] - mid2);
    }
    if (left <= right)
        Console.WriteLine(mid1);
    else
        Console.WriteLine(mid2);
}