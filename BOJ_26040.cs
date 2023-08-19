 // BOJ_26040

using System.Text;
    
        
string inputValue = Console.ReadLine();
string[] ConvertWord = Console.ReadLine().Split(" ");
string lowerWord = "";
foreach (var one in ConvertWord)
{
    lowerWord += one.ToLower();
}
StringBuilder sb = new StringBuilder();
int count = 0;
for (int i = 0; i < inputValue.Length; i++)
{
    count = 0;
    while (count < ConvertWord.Length)
    {
        if (inputValue[i] == char.Parse(ConvertWord[count]))
        {
            sb.Append( lowerWord[count]);
            break;
        }
        count++;
    }
    if (count == ConvertWord.Length)
        sb.Append(inputValue[i]);
}
Console.WriteLine(sb);
        