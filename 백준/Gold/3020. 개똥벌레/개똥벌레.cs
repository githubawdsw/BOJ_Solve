// BOJ_3020


int[] inputnh = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnh[0];
int h = inputnh[1];

List<int> seogList = new List<int>();
List<int> jongList = new List<int>();
for (int i = 0; i < n; i++)
{
    if(i % 2 == 0)
        seogList.Add(int.Parse(Console.ReadLine()));
    else
        jongList.Add(int.Parse(Console.ReadLine()));
}

seogList.Sort();
jongList.Sort();

int ansLen = int.MaxValue;
int ansCnt = 0;
for (int i = 0; i < h; i++)
{
    int seogCount = Binary_Search(i + 1, seogList);
    int jongCount = Binary_Search(h - i, jongList);
    int count = seogCount + jongCount;

    if (count < ansLen)
    {
        ansLen = count;
        ansCnt = 1;
    }
    else if (count == ansLen)
        ansCnt++;
}

Console.WriteLine($"{ansLen} {ansCnt}");


int Binary_Search(int height , List<int> list)
{
    int left = 0;
    int right = list.Count - 1;
    while (left <= right)
    {
        int mid = (left + right) / 2;
        if (list[mid] < height)
            left = mid + 1;
        else
            right = mid - 1;
    }
    return list.Count - (right + 1);
}