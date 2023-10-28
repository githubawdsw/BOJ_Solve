// BOJ_11663



using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[] pos = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Array.Sort(pos);
for (int i = 0; i < m; i++)
{
    int[] line = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    int left = 0;
    if (line[0] > pos[n-1])
    {
        sb.AppendLine("0");
        continue;
    }
    else
    {
        int start = 0;
        int end = n - 1;
        int val = 0;
        while (start <= end)
        {
            int mid = (start + end) / 2;
            if (line[0] <= pos[mid])
            {
                val = mid;
                end = mid - 1;
            }
            else
                start = mid + 1;
        }
        left = val;
    }

    int right = n - 1;
    if (line[1] < pos[0])
    {
        sb.AppendLine("0");
        continue;
    }
    else
    {
        int start = 0;
        int end = n - 1;
        int val = 0;
        while (start <= end)
        {
            int mid = (start + end) / 2;
            if (line[1] < pos[mid])
                end = mid - 1;
            else
            {
                start = mid + 1;
                val = start;
            }
        }
        right = val;
    }

    sb.AppendLine((right - left).ToString());
}

Console.WriteLine(  sb );
