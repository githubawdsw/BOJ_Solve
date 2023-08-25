// BOJ_1157


string str = Console.ReadLine();

int[] counting = new int[30];
for (int i = 0; i < str.Length; i++)
{
    int c = str[i];
    if (c - 'A' <= 26)
        c -=  'A';
    else
        c -= 'a';
    counting[c]++;
}
bool check = false;
int ans = 0;
for (int i = 0; i < counting.Length; i++)
{
    if (!check && counting[i] == counting.Max())
    {
        check = true;
        ans = i + 'A';
    }
    else if(check && counting[i] == counting.Max())
    {
        Console.WriteLine("?");
        return;
    }
}
Console.WriteLine( (char) ans);
