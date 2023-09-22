// BOJ_26043


using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();
List<int>[] numberList = new List<int>[3];
numberList[0] = new List<int>();
numberList[1] = new List<int>();
numberList[2] = new List<int>();

for (int i = 0; i < n; i++)
{
    string[] inputInfo = Console.ReadLine().Split(' ');
    if (inputInfo[0] == "1")
        q.Enqueue(new Tuple<int, int>(int.Parse(inputInfo[1]), int.Parse(inputInfo[2])));
    else
    {
        var cur = q.Dequeue();
        if (cur.Item2 == int.Parse(inputInfo[1]))
            numberList[0].Add(cur.Item1);
        else
            numberList[1].Add(cur.Item1);
    }
}

while (q.Count > 0)
{
    var cur = q.Dequeue();
    numberList[2].Add(cur.Item1);
}

numberList[0].Sort();
numberList[1].Sort();
numberList[2].Sort();
for (int i = 0; i < numberList[0].Count; i++)
    sb.Append($"{numberList[0][i]} ");
if (numberList[0].Count == 0)
    sb.Append("None");
sb.Append("\n");

for (int i = 0; i < numberList[1].Count; i++)
    sb.Append($"{numberList[1][i]} ");
if (numberList[1].Count == 0)
    sb.Append("None");
sb.Append("\n");

for (int i = 0; i < numberList[2].Count; i++)
    sb.Append($"{numberList[2][i]} ");
if (numberList[2].Count == 0)
    sb.Append("None");



Console.WriteLine(  sb);
