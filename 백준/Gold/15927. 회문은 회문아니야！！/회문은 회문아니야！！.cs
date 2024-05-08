// BOJ_15927


string str = Console.ReadLine();

int start = 0;
int end = str.Length - 1;
bool isOneWord = true;
bool isPalindrome = true;
for (int i = 0; i < str.Length; i++)
{
    if (str[i]!= str[start])
    {
        isOneWord = false;
        break;
    }
}

if (isOneWord)
{
    Console.WriteLine(-1);
    return;
}

while (start <= end)
{
    if (str[start] != str[end])
    {
        isPalindrome = false;
        break;
    }
    start++;
    end--;
}

if(isPalindrome)
    Console.WriteLine(str.Length - 1);
else
    Console.WriteLine(str.Length);