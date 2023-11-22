// BOJ_12904


string s = Console.ReadLine();
string t = Console.ReadLine();

Queue<string> q = new Queue<string>();
q.Enqueue(t);
while (q.Count > 0)
{
    var cur = q.Dequeue();
    if(cur == s)
    {
        Console.WriteLine(1);
        return;
    }
    if (cur.Length < s.Length)
        continue;

    bool check = false;
    if(cur.Last() == 'B')
        check = true;

    string temp = cur.Substring(0, cur.Length - 1);
    if (check)
        temp = new string(temp.Reverse().ToArray());
    q.Enqueue(temp);
}

Console.WriteLine(0);
