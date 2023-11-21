// BOJ_2477


int k = int.Parse(Console.ReadLine());

List<Tuple<int,int>> list = new List<Tuple<int,int>>();
for (int i = 0; i < 6; i++)
{
    int[] inputdl = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int dir = inputdl[0];
    int length = inputdl[1];
    list.Add(new Tuple<int, int>(dir, length));
}

for (int i = 0; i < 6; i++)
    list.Add(list[i]);

int bigSquare = 1;
int smallSquare = 1;
for (int i = 2; i < 11; i++)
{
    if (list[i].Item1 == list[i - 2].Item1 && list[i + 1].Item1 == list[i - 1].Item1)
    {
        smallSquare = list[i].Item2 * list[i - 1].Item2;
        break;
    }
}

int x = 0;
int y = 0;
for (int i = 0; i < 6; i++)
{
    if (list[i].Item1 == 1 || list[i].Item1 == 2)
        x = Math.Max(x, list[i].Item2);
    if (list[i].Item1 == 3 || list[i].Item1 == 4)
        y = Math.Max(y, list[i].Item2);
}
bigSquare = x * y;

Console.WriteLine((bigSquare - smallSquare) * k);