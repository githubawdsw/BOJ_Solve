// BOJ_2587


List<int> list = new List<int>();
int sum = 0;
for (int i = 0; i < 5; i++)
{
    int input = int.Parse(Console.ReadLine());
    list.Add(input);
    sum += input;
}

list.Sort();
Console.WriteLine(  sum / 5);
Console.WriteLine(list[2]);

