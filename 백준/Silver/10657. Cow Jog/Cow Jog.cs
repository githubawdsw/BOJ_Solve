// BOJ_10657


int n = int.Parse(Console.ReadLine());

Stack<Tuple<int, int>> s = new Stack<Tuple<int, int>>();
for (int i = 0; i < n; i++)
{
    string[] inputInfo = Console.ReadLine().Split(' ');
    int pos = int.Parse(inputInfo[0]);
    int velocity = int.Parse(inputInfo[1]);
    s.Push(new Tuple<int, int>(pos, velocity));
}

int count = 1;
int min = s.Pop().Item2;
while (s.Count > 0)
{
    var compare = s.Pop();
    if (min >= compare.Item2)
        count++;
    min = Math.Min(compare.Item2, min);
}

Console.WriteLine(  count);
