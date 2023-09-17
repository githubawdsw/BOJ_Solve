// BOJ_1213



string input = Console.ReadLine();
int[] arr = new int[30];
for (int i = 0; i < input.Length; i++)
    arr[input[i] - 'A' + 1]++;
int count = 0;
int findone = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 1)
    {
        findone = i;
        count++;
    }
    if(count > 1)
    {
        Console.WriteLine("I'm Sorry Hansoo");
        return;
    }
    arr[i] /= 2;
}

string temp = "";
for (int i = 0; i < arr.Length; i++)
{
    while (arr[i] != 0)
    {
        temp += (char)(i - 1 + 'A');
        arr[i]--;
    }
}

string ans = "";
if(count == 0)
    ans = temp + new string(temp.Reverse().ToArray());
else
    ans = temp + (char)('A' + findone - 1) + new string(temp.Reverse().ToArray());

Console.WriteLine(  ans);

