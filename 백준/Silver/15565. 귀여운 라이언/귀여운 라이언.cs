// BOJ_15565


int[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnk[0];
int k = inputnk[1];

int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
List<int> list = new List<int>();
for (int i = 0; i < n; i++)
{
    if (inputArr[i] == 1)
        list.Add(i);
}

int ans = 1000005;
int left = 0;
int right = 0;
while (right < list.Count)
{
    if (right - left + 1 < k)
        right++;
    else
    {
        ans = Math.Min(ans, list[right] - list[left] + 1);
        left++;
    }
}

if(ans == 1000005)
    Console.WriteLine(-1);
else
    Console.WriteLine(ans);