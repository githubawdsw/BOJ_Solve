// BOJ_11004



string[] inputnk = Console.ReadLine().Split(' ');
int n = int.Parse(inputnk[0]);
int k = int.Parse(inputnk[1]);

string[] inputarr = Console.ReadLine().Split(" ");
List<int> list = new List<int>();
for (int i = 0; i < n; i++)
    list.Add(int.Parse(inputarr[i]));

list.Sort();
Console.WriteLine(list[k-1]);