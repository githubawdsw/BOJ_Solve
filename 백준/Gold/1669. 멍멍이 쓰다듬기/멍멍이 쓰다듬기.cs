// BOJ_1669


int[] inputxy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int x = inputxy[0];
int y = inputxy[1];

int dis = y - x;

if (dis == 1)
    Console.WriteLine(1);
else
{
    Console.WriteLine((int)(2 * Math.Sqrt(dis) - 1e-9));
}