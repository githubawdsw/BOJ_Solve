// BOJ_11319



int t = int.Parse(Console.ReadLine());


for (int i = 0; i < t; i++)
{
    string inputs = Console.ReadLine();
    int a = 0, b = 0, c = 0;
    for (int j = 0; j < inputs.Length; j++)
    {

        if (inputs[j] == 'A' || inputs[j] == 'E' || inputs[j] == 'I' || inputs[j] == 'O' || inputs[j] == 'U'
             || inputs[j] == 'a' || inputs[j] == 'e' || inputs[j] == 'i' || inputs[j] == 'o' || inputs[j] == 'u')
            a++;
        else
            b++;
        if (inputs[j] == ' ')
            b--;
    }
    Console.WriteLine(  $"{b} {a}");
}
        