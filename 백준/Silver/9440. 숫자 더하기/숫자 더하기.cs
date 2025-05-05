// BOJ_9440


using System.Text;

StringBuilder sb = new StringBuilder();
while (true)
{
    string[] inputInfo = Console.ReadLine().Split();
    int n = int.Parse(inputInfo[0]);

    if (n == 0)
        break;

    List<int> arr = new List<int>();
    int zeroCount = 0;
    for (int i = 0; i < n; i++)
    {
        if (inputInfo[i + 1] == "0")
            zeroCount++;
        else
            arr.Add(int.Parse(inputInfo[i + 1]));
    }

    arr.Sort();

    int check = 1;
    List<int> list1 = new List<int>();
    List<int> list2 = new List<int>();

    for (int i = 0; i < arr.Count; i++)
    {
        var target = arr[i];

        if(check == 1)
        {
            list1.Add(target);
            check = 0;
        }
        else
        {
            list2.Add(target);
            check = 1;
        }
    }

    string str1 = list1[0].ToString();
    string str2 = list2[0].ToString();

    if (list1.Count > list2.Count && zeroCount > 0)
    {
        str2 += "0";
        zeroCount--;
    }

    while (zeroCount-- > 0)
    {
        if (str1.Length == str2.Length)
            str1 += "0";
        else
            str2 += "0";
    }

    for (int i = 1; i < list1.Count; i++)
    {
        str1 += list1[i];
    }
    for (int i = 1; i < list2.Count; i++)
    {
        str2 += list2[i];
    }

    sb.AppendLine((long.Parse(str1) + long.Parse(str2)).ToString());
}

Console.WriteLine(sb);

