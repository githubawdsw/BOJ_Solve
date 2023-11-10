// BOJ_2628



int[] inputrc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int r = inputrc[0];
int c = inputrc[1];

int cutCount = int.Parse(Console.ReadLine());
List<int> rlist = new List<int>();
List<int> clist = new List<int>();
rlist.Add(0); clist.Add(0); rlist.Add(r); clist.Add(c);
for (int i = 0; i < cutCount; i++)
{
    int[] line = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    if (line[0] == 1)
        rlist.Add(line[1]);
    else
        clist.Add(line[1]);
}

rlist.Sort(); clist.Sort();

List<int> area = new List<int>();
for (int i = 1; i < rlist.Count; i++)
{
    for (int j = 1; j < clist.Count; j++)
        area.Add((rlist[i] - rlist[i - 1]) * (clist[j] - clist[j - 1]));
}

Console.WriteLine(area.Max());