// BOJ_2776

using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());

while (t-- > 0)
{
    List<int> list = new List<int>();
    int n = int.Parse(Console.ReadLine());
    string[] inputNarr = Console.ReadLine().Split(' ');

    for (int i = 0; i < n; i++)
        list.Add(int.Parse(inputNarr[i]));

    list.Sort();

    int m = int.Parse(Console.ReadLine());
    string[] inputMarr = Console.ReadLine().Split(' ');

    for (int i = 0; i < m; i++)
    {
        int target = int.Parse(inputMarr[i]);
        bool check = false;
        int left = 0;
        int right = n - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (list[mid] == target)
            {
                check = true;
                break;
            }
            else if (list[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        if (check)
            sb.AppendLine("1");
        else
            sb.AppendLine("0");
    }
}
Console.WriteLine(  sb);
