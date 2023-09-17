// BOJ_2204


using System.Text;

StringBuilder sb = new StringBuilder();

while (true)
{
    int n = int.Parse(Console.ReadLine());
    if (n == 0)
        break;
    string[] inputWord = new string[n];
    string[] lowerResult = new string[n];
    for (int i = 0; i < n; i++)
    {
        inputWord[i] = Console.ReadLine();
        lowerResult[i] = inputWord[i].ToLower();
    }
    Array.Sort(lowerResult);

    for (int i = 0; i < inputWord.Length; i++)
    {
        if (lowerResult[0] == inputWord[i].ToLower())
        {
            sb.AppendLine(inputWord[i]);
            break;
        }
    }
}

Console.Write(sb);