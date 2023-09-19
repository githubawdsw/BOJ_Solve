// BOJ_3613


string input = Console.ReadLine();
if (input[0] == '_' || input[input.Length -1] == '_' ||input[0] < 90)
{
    Console.WriteLine("Error!");
    return;
}

if (input.Contains('_'))
{
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] <= 90 )
        {
            Console.WriteLine("Error!");
            return;
        }

        if (input[i] == '_')
        {
            if (i + 1 < input.Length && (input[i + 1] == '_' || input[i + 1] <= 90))
            {
                Console.WriteLine("Error!");
                return;
            }
            char convert = (char)(input[i + 1] - 32);
            input = input.Remove(i, 2).Insert(i, convert.ToString());
        }
    }
}
else
{
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] < 95)
        {
            char convert = (char)(input[i] + 32);
            input = input.Remove(i, 1).Insert(i, "_").Insert(i+1, convert.ToString());
            i++;
        }
    }
}
Console.WriteLine(  input);