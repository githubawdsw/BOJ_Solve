// BOJ_14215



string[] inputLength = Console.ReadLine().Split(' ');

List<int> list = new List<int>();
for (int i = 0; i < 3; i++)
    list.Add(int.Parse(inputLength[i]));

list.Sort();
int sum = list[0] + list[1];
while ( sum <= list[2])
    list[2]--;

Console.WriteLine(  sum + list[2]);
