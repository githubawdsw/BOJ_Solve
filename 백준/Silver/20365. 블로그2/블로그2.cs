// BOJ_20365


int n = int.Parse(Console.ReadLine());

string color = Console.ReadLine();

Dictionary<char, int> dict = new Dictionary<char, int> 
{ 
    { 'B', 0 } ,
    { 'R', 0 }
};

dict[color[0]]++;
for (int i = 1; i < n; i++)
{
    if (color[i - 1] != color[i])
        dict[color[i]]++;
}

Console.WriteLine(Math.Min(dict['B'], dict['R']) + 1);