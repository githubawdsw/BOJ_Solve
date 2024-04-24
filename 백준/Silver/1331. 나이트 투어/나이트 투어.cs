// BOJ_1331



HashSet<string> hs = new HashSet<string>();
int count = 1;
string start = Console.ReadLine();
hs.Add(start);
string cur = start;
string next = "";
while (count++ != 36)
{
    next = Console.ReadLine();
    if (!hs.Contains(next) && ((Math.Abs(cur[0] - next[0]), Math.Abs(cur[1] - next[1])) == (1, 2)
    || (Math.Abs(cur[0] - next[0]), Math.Abs(cur[1] - next[1])) == (2, 1)))
        hs.Add(next);
    else
        break;
    cur = next;
}
if (hs.Count == 36 && ((Math.Abs(start[0] - next[0]), Math.Abs(start[1] - next[1])) == (1, 2)
    || (Math.Abs(start[0] - next[0]), Math.Abs(start[1] - next[1])) == (2, 1)))
    Console.WriteLine("Valid");
else
    Console.WriteLine("Invalid");