//BOJ_24060


using System.Text;

StringBuilder sb = new StringBuilder();
string[] inputnk = Console.ReadLine().Split(' ');
int n = int.Parse(inputnk[0]);
int k = int.Parse(inputnk[1]);

string[] inputarr = Console.ReadLine().Split(" ");
string[] temp = new string[n];
int count = 0;

mergeSort(0 , n-1);
if (count < k)
    sb.AppendLine("-1");

Console.WriteLine(  sb);


void mergeSort(int start , int end)
{
    if(start < end)
    {
        int mid = (start + end) / 2;
        mergeSort(start, mid);
        mergeSort(mid + 1, end);
        merge(start, mid, end);
    }
}

void merge(int start, int mid ,int end)
{
    int i = start; int j = mid + 1; int t = 0;
    while (i <= mid && j <= end)
    {
        if (int.Parse(inputarr[i]) <= int.Parse( inputarr[j]))
            temp[t++] = inputarr[i++];
        else
            temp[t++] = inputarr[j++];
    }   

    while (i <= mid)
        temp[t++] = inputarr[i++];

    while (j <= end)
        temp[t++] = inputarr[j++];

    i = start;
    t = 0;
    while (i <= end)
    {
        inputarr[i++] = temp[t++].ToString();

        if (++count == k)
            sb.AppendLine(inputarr[i - 1]);
    }

}
