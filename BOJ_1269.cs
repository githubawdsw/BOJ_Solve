// BOJ_1269


string[] inputABlength = Console.ReadLine().Split(' ');
int a = int.Parse(inputABlength[0]);
int b = int.Parse(inputABlength[1]);
string[] inputA = Console.ReadLine().Split(' ');
string[] inputB = Console.ReadLine().Split(" ");

List<int> alist = new List<int>();
List<int> blist = new List<int>();
for (int i = 0; i < inputA.Length; i++)
    alist.Add(int.Parse(inputA[i]));
for (int i = 0; i < inputB.Length; i++)
    blist.Add(int.Parse(inputB[i]));

alist.Sort();
blist.Sort();
HashSet<int> ahs = new HashSet<int>();
HashSet<int> bhs = new HashSet<int>();

int length = Math.Max(alist.Count, blist.Count);

int ac = 0;
int bc = 0;
while (ac != inputA.Length && bc != inputB.Length )
{
    if (alist[ac] > blist[bc])
    {
        bhs.Add(blist[bc]);
        bc++;
    }
    else if (alist[ac] < blist[bc])
    {
        ahs.Add(alist[ac]);
        ac++;
    }
    else
    {
        ac++;
        bc++;
    }
}

while (ac < inputA.Length)
{
    if (alist[ac] != blist[bc - 1])
        ahs.Add(alist[ac]);
    ac++;
}
while (bc < inputB.Length)
{
    if (blist[bc] != alist[ac - 1])
        bhs.Add(blist[bc]);
    bc++;
}


Console.WriteLine(  ahs.Count + bhs.Count);

