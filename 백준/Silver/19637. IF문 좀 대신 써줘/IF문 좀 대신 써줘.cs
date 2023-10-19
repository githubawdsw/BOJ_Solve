// BOJ_19637


using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m  = inputnm[1];

List<Tuple<string, int>> tupleList = new List<Tuple<string, int>>();
for (int i = 0; i < n; i++)
{
    string[] inputTitle = Console.ReadLine().Split(' ');
    string title = inputTitle[0];
    int value = int.Parse(inputTitle[1]);
    tupleList.Add(new Tuple<string, int>(title, value));
}

tupleList = tupleList.OrderBy(x => x.Item2).ToList();
for (int i = 0; i < m; i++)
{
    int input = int.Parse(Console.ReadLine());

    int left = 0;
    int right = n - 1;
    int mid = 0;
    while (left <= right)
    {
        mid = (left + right) / 2;
        if (input <= tupleList[mid].Item2 )
            right = mid - 1;
        else
            left = mid + 1;
    }
    sb.AppendLine(tupleList[left].Item1);
}

Console.WriteLine(  sb );