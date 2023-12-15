// BOJ_19939


int[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnk[0];
int k = inputnk[1];

int[] basket = new int[k + 5];

int count = k * (k + 1) / 2;
if (n < count)
    Console.WriteLine(-1);
else
{
    int amount = n - count;
    if(amount % k == 0)
        Console.WriteLine(k - 1);
    else
        Console.WriteLine(k);
}