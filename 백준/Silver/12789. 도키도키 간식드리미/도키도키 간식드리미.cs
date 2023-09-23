// BOJ_12789


int n = int.Parse(Console.ReadLine());

string[] inputarr = Console.ReadLine().Split(' ');

int number = 1;
int idx = 0;
Stack<int> s = new Stack<int>();
while (idx < n)
{
    if (number == int.Parse(inputarr[idx]))
        number++;
    else if (s.Count != 0 && s.Peek() == number)
    {
        s.Pop();
        number++;
        continue;
    }
    else
        s.Push(int.Parse(inputarr[idx]));
    idx++;
}
for (int i = 0; i < s.Count; i++)
{
    if (s.Peek() != number)
    {
        Console.WriteLine("Sad");
        return;
    }
    s.Pop();
    number++;
}
Console.WriteLine("Nice");