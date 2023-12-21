// BOJ_1183


int n = int.Parse(Console.ReadLine());
List<int> list = new List<int>();
for (int i = 0; i < n; i++)
{
    int[] inputArrive = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    list.Add(inputArrive[0] - inputArrive[1]);
}

if(n % 2 == 1)
{
    Console.WriteLine(1);
    return;
}

list.Sort();
int min = list[list.Count / 2 - 1];
int max = list[list.Count / 2];

int count = 1;
count += max - min;
Console.WriteLine(count);