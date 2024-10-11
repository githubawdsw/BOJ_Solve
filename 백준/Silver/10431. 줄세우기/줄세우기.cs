// BOJ_10431


using System.Text;

StringBuilder sb = new StringBuilder();
int p = int.Parse(Console.ReadLine());
int tc = 1;
while (tc <= p)
{
    int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    List<int> list = new List<int>();
    for (int i = 1; i < inputInfo.Length; i++)
    {
        list.Add(inputInfo[i]);
    }

    List<int> seq = new List<int>();
    seq.Add(list[0]);
    int ans = 0;
    for (int i = 1; i < list.Count; i++)
    {
        bool check = false;
        int count = 0;
        int pos = 0;
        for (int j = 0; j < seq.Count; j++)
        {
            if (list[i] < seq[j])
            {
                check = true;
                count = seq.Count - j;
                pos = j;
                break;
            }
        }
        if (check)
            seq.Insert(pos, list[i]);
        else
            seq.Add(list[i]);
        ans += count;
    }
    sb.AppendLine(tc++.ToString() + " " + ans.ToString());
}

Console.WriteLine(sb);