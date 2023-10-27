//BOJ_2493

using System.Text;

int n = int.Parse(Console.ReadLine());
string[] inputheight = Console.ReadLine().Split(' ');

StringBuilder sb = new StringBuilder();
Stack<Tuple<int, int>> s = new Stack<Tuple<int, int>>();
s.Push(new Tuple<int,int>( 1000000001, 0));
for (int i = 1; i <= inputheight.Length; i++)
{
    int height = int.Parse(inputheight[i-1]);

    while (s.Peek().Item1 < height)
        s.Pop();
    sb.Append($"{s.Peek().Item2} ");
    s.Push(new Tuple<int, int>( height, i));
}

Console.WriteLine(  sb);