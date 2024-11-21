// BOJ_15729


int n = int.Parse(Console.ReadLine());
string[] input = Console.ReadLine().Split(' ');
List<int> list = new List<int>();
for (int i = 0; i < n; i++)
{
    list.Add(int.Parse(input[i]));
}

int[] button = new int[1000005];
int count = 0;
for (int i = 0; i < n; i++)
{
    if (button[i] != list[i])
    {
        button[i] = button[i] == 0 ? 1 : 0;
        button[i + 1] = button[i + 1] == 0 ? 1 : 0;
        button[i + 2] = button[i + 2] == 0 ? 1 : 0;
        count++;
    }
}

Console.WriteLine(count);
    