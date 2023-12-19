// BOJ_9935


using System.Text;

StringBuilder sb = new StringBuilder();

string inputstr = Console.ReadLine();
string explodestr = Console.ReadLine();
Stack<char> s = new Stack<char>();
int last = explodestr.Length - 1;

for (int i = 0; i < inputstr.Length; i++)
{
    s.Push(inputstr[i]);
    if(s.Peek() == explodestr[last] && s.Count > last)
    {
        bool check = true;
        char[] arr = new char[40];
        for (int j = last; j >= 0; j--)
        {
            if(s.Peek() != explodestr[j])
                check = false;
            arr[j] = s.Pop();
        }
        if(!check)
        {
            for (int j = 0; j <= last; j++)
                s.Push(arr[j]);
        }
    }
}

if(s.Count == 0)
{
    Console.WriteLine("FRULA");
    return;
}

while (s.Count > 0)
    sb.Append(s.Pop());

Console.WriteLine(sb.ToString().Reverse().ToArray());

