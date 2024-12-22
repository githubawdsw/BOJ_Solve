// BOJ_17828


using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputnx = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnx[0];
int x = inputnx[1];

if (n * 26 < x || n > x)
{
    Console.WriteLine("!");
    return;
}

while (n * 26 > x)
{
    int value = (n - 1) * 26;
    if (value > x)
    {
        sb.Append('A');
        x--;
    }
    else
    {
        int temp = x - value;
        sb.Append((char)(temp + 'A' - 1));
        x -= temp;
    }
    n--;
}

int count = x / 26;
while (count > 0)
{
    sb.Append('Z');
    n--;
    count--;
}

if(n == 0 && count == 0)
{
    Console.WriteLine(sb);
}
else
{
    Console.WriteLine("!");
}