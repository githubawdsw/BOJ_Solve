// BOJ_2666


int closet = int.Parse(Console.ReadLine());
int[] openDoor = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int useCloset = int.Parse(Console.ReadLine());
List<int> list = new List<int>();
Dictionary<(int, int, int), int> dp = new Dictionary<(int, int, int), int>();
for (int i = 0; i < useCloset; i++)
{
    list.Add(int.Parse(Console.ReadLine()));
}

Console.WriteLine(Move(openDoor[0], openDoor[1], 0));



int Move(int a, int b, int count)
{
    if(count == useCloset) 
        return 0;

    if(dp.ContainsKey((a, b, count)))
        return dp[(a, b, count)];

    int target = list[count];
    int moveA = Math.Abs(target - a) + Move(target, b, count + 1);
    int moveB = Math.Abs(target - b) + Move(a, target, count + 1);

    dp[(a, b, count)] = Math.Min(moveA, moveB);
    return dp[(a, b, count)];
}