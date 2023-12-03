// BOJ_16937

using System.Collections.Generic;

int[] inputhw = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int h = inputhw[0];
int w = inputhw[1];
int n = int.Parse(Console.ReadLine());

List<Tuple<int,int>> list = new List<Tuple<int, int>>();
for (int i = 0; i < n; i++)
{
    int[] inputrc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    list.Add(new(inputrc[0], inputrc[1]));
}


int ans = 0;
for (int i = 0; i < n; i++)
{
    for (int j = i + 1; j < n; j++)
    {
        var first = list[i];
        var second = list[j];

        sticker(first, second);
        sticker(new Tuple<int, int>(first.Item2, first.Item1), second);
    }
}

Console.WriteLine(ans);


void sticker(Tuple<int,int> first , Tuple<int,int> second)
{
    int max = Math.Max(first.Item1, second.Item1);
    int length = first.Item2 + second.Item2;
    if ((max <= h && length <= w) || (max <= w && length <= h))
        ans = Math.Max(ans, first.Item1 * first.Item2 + second.Item1 * second.Item2);

    max = Math.Max(first.Item1, second.Item2);
    length = first.Item2 + second.Item1;
    if ((max <= h && length <= w) || (max <= w && length <= h))
        ans = Math.Max(ans, first.Item1 * first.Item2 + second.Item1 * second.Item2);

    max = Math.Max(first.Item2, second.Item1);
    length = first.Item1 + second.Item2;
    if ((max <= h && length <= w) || (max <= w && length <= h))
        ans = Math.Max(ans, first.Item1 * first.Item2 + second.Item1 * second.Item2);

    max = Math.Max(first.Item2, second.Item2);
    length = first.Item1 + second.Item1;
    if ((max <= h && length <= w) || (max <= w && length <= h))
        ans = Math.Max(ans, first.Item1 * first.Item2 + second.Item1 * second.Item2);
}
