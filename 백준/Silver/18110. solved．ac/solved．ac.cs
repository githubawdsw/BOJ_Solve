// BOJ_18110



float n = float.Parse(Console.ReadLine());
List<int> list = new List<int>();
for (int i = 0; i < n; i++)
    list.Add(int.Parse(Console.ReadLine()));

list.Sort();
if(n == 0)
{
    Console.WriteLine(0);
    return;
}

float val = (n * 15) / 100;
int cutLine;
if (val - (int)val < 0.5f)
    cutLine = (int)val;
else
    cutLine = (int)val + 1;

float sum = 0;
for (int i = cutLine; i < list.Count - cutLine; i++)
    sum += list[i];

val = sum / (list.Count - (2 * cutLine));

int ans;
if (val - (int)val < 0.5f)
    ans = (int)val;
else
    ans = (int)val + 1;

Console.WriteLine(ans);