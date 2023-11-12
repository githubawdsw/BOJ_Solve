// BOJ_9024


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int n = inputnk[0];
    int k = inputnk[1];
    
    int[] inputnInteger = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    Array.Sort(inputnInteger);

    int left = 0;
    int right = n - 1;
    int count = 0;
    int val = Math.Abs(inputnInteger[left] + inputnInteger[right] - k);
    while (left < right)
    {
        if (Math.Abs(inputnInteger[left] + inputnInteger[right] - k) < val)
        {
            count = 1;
            val = Math.Abs(inputnInteger[left] + inputnInteger[right] - k);
        }
        else if (Math.Abs(inputnInteger[left] + inputnInteger[right] - k) == val)
            count++;

        if (inputnInteger[left] + inputnInteger[right] >= k)
            right--;
        else
            left++;
    }
    sb.AppendLine(count.ToString());
}

Console.WriteLine(sb);
