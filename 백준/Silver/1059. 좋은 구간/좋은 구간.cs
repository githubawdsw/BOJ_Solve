// BOJ_1059



int l = int.Parse(Console.ReadLine());
string[] inputint = Console.ReadLine().Split(' ');
int n = int.Parse(Console.ReadLine());

List<int> list = new List<int>();
for (int i = 0; i < l; i++)
    list.Add(int.Parse(inputint[i]));

list.Add(0);
list.Add(1000);
list.Sort();


int idx = 0;
while (idx < list.Count && n >= list[idx])
    idx++;

int left = idx - 1;
int right = idx;

int count = 0;

for (int i = list[left] + 1; i <= n; i++)
{
    for (int j = n; j < list[right]; j++)
    {
        if (i == j)
            continue;
        count++;
    }
}

Console.WriteLine(  count );
