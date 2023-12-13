// BOJ_24390



int[] inputTime = Array.ConvertAll(Console.ReadLine().Split(':'), int.Parse);
int m = inputTime[0];
int s = inputTime[1];
s += m * 60;

int count = 0;
int value = s % 600;
count = s / 600;

count += value / 60;
value %= 60;

if(value / 30 > 0)
    count += (value / 30) - 1;
value %= 30;

count += value / 10;
value %= 10;

Console.WriteLine(count + 1);
