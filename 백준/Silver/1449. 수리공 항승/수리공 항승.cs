// BOJ_1449



string[] inputnl = Console.ReadLine().Split(' ');
int n = int.Parse(inputnl[0]);
int l = int.Parse(inputnl[1]);

string[] inputPos = Console.ReadLine().Split(" ");
List<int>list = new List<int>();
for (int i = 0; i < n; i++)
    list.Add(int.Parse(inputPos[i]));
list.Sort();

int idx = list[0];
int count = 0;
for (int i = 0; i < list.Count; i++)
{
    if (list[i] > idx)
    {
        idx = list[i];
        idx += l;
        count++;
    }
    else if (list[i] == idx)
    {
        idx += l ;
        count++;
    }
}

Console.WriteLine(  count );
