// BOJ_16234



List<Tuple<int, int>> list = new List<Tuple<int, int>>();
for (int i = 0; i < 3; i++)
{
    int[] inputxy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int x = inputxy[0];
    int y = inputxy[1];
    list.Add(new Tuple<int, int>(x, y));
}

bool check = false;
if ((list[0].Item2 - list[1].Item2 ) * (list[1].Item1 - list[2].Item1) == (list[0].Item1 - list[1].Item1) * (list[1].Item2 - list[2].Item2))
    check = true;

if (check)
    Console.WriteLine("WHERE IS MY CHICKEN?");
else
    Console.WriteLine("WINNER WINNER CHICKEN DINNER!");

