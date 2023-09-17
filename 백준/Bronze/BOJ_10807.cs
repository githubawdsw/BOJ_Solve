
int n = int.Parse(Console.ReadLine());
string[] inputarr = Console.ReadLine().Split(' ');
int v = int.Parse(Console.ReadLine());

int[] counting = new int[201];
for (int i = 0; i < n; i++)
    counting[int.Parse(inputarr[i]) + 100]++;

Console.WriteLine(counting[v +100]);
