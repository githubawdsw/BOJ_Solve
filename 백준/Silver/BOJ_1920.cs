// BOJ_1920

using System.Text;

StringBuilder sb = new StringBuilder();
        
int n = int.Parse(Console.ReadLine());
string[] inputn = Console.ReadLine().Split(' ');
List<int> nlist = new List<int>();
for (int i = 0; i < inputn.Length; i++)
    nlist.Add(int.Parse(inputn[i]));
nlist.Sort();

int m = int.Parse(Console.ReadLine());
string[] inputm = Console.ReadLine().Split(' ');

int idx = 0;
int ans;
while (m > idx)
{
    int start = 0;
    int end = n - 1;
    int mid;

    ans = 0;
    while (start <= end)
    {
        mid = (start + end) / 2;
        if (nlist[mid] == int.Parse(inputm[idx]))
        {
            ans = 1;
            break;
        }
        else if (nlist[mid] < int.Parse(inputm[idx]))
            start = mid + 1;
        else
            end = mid - 1;
    }
    sb.AppendLine(ans.ToString());
    idx++;
}
Console.WriteLine(sb);

