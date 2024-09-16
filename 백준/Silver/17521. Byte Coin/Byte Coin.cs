// BOJ_17521


int[] inputnw = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnw[0];
int w = inputnw[1];

List<int> list = new List<int>();
for (int i = 0; i < n; i++)
{
    int inputs = int.Parse(Console.ReadLine());
    list.Add(inputs);
}

long money = w;
long purchase = 0;
for (int i = 0; i < list.Count - 1; i++)
{
    if (list[i] < list[i + 1] && purchase == 0)
    {
        purchase = money / list[i];
        money -= purchase * list[i];
    }
    else if(list[i] > list[i + 1] && purchase != 0)
    {
        money += list[i] * purchase;
        purchase = 0;
    }
}

if(purchase != 0)
{
    money += list.Last() * purchase;
}

Console.WriteLine(money);