// BOJ_12845


int n = int.Parse(Console.ReadLine());
int[] inputCardLevel = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int idx = 0;
int max = 0;
List<int> list = new List<int>();
int ans = 0;
for (int i = 0; i < n; i++)
{
    if(max < inputCardLevel[i])
    {
        idx = i;
        max = inputCardLevel[i];
    }
    list.Add(inputCardLevel[i]);
}

while (list.Count > 1)
{
    int left = Check(idx, -1);
    int right = Check(idx, 1);
    if (right < left)
    {
        list.RemoveAt(idx - 1);
        ans += max + left;
        idx--;
    }
    else
    {
        list.RemoveAt(idx + 1);
        ans += max + right;
    }

}

if(n == 1)
    Console.WriteLine(max);
else
    Console.WriteLine(ans);


int Check(int idx, int dir)
{
    int target = idx + dir;
    if (target < 0 || target >= list.Count)
        return -1;

    return list[target];
}