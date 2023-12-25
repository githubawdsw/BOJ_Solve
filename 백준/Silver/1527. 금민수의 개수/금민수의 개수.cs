// BOJ_1527


int[] inputab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int a = inputab[0];
int b = inputab[1];
List<int> list = new List<int>();

recur(1, 4);
recur(1, 7);

int count = 0;
for (int i = 0; i < list.Count; i++)
{
    if (list[i] >= a && list[i] <= b)
        count++;
}

Console.WriteLine(count);


void recur(int depth, int value)
{
    list.Add(value);
    if(depth == 9)
    {
        return;
    }

    recur(depth + 1, value * 10 + 4);
    recur(depth + 1, value * 10 + 7);
}