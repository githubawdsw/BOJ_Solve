// BOJ_2866



using System.Text;

int[] inputrc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int r = inputrc[0];
int c  = inputrc[1];

int count = 0;
List<string>  strList = new List<string>();
for (int i = 0; i < r; i++)
    strList.Add(Console.ReadLine());

int start = 0;
int end = r - 1;
while (start <= end)
{
    int mid = (start + end) / 2;
    HashSet<string> hs = new HashSet<string>();
    bool check = false;
    for (int i = 0; i < c; i++)
    {
        StringBuilder sb = new StringBuilder();
        for (int j = mid; j < r; j++)
            sb.Append(strList[j][i]);
        if(!hs.Contains( sb.ToString()))
            hs.Add(sb.ToString());
        else
        {
            check = true;
            break;
        }
    }
    if (check)
        end = mid - 1;
    else
        start = mid + 1;
}

Console.WriteLine(  start  - 1);
