// BOJ_20364


using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputnq = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnq[0];
int q = inputnq[1];
bool[] used = new bool[1050000];

for (int i = 0; i < q; i++)
{
    int groudNum = int.Parse(Console.ReadLine());

    int min = 0;
    int target = groudNum;
    while (target > 0)
    {
        if (used[target])
            min = target;
        target = target / 2;
    }
    if(min == 0)
        used[groudNum] = true;

    sb.AppendLine(min.ToString());
}

Console.WriteLine(sb);