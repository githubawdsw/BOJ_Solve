// BOJ_11104


int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string inputbinary = Console.ReadLine();
    Console.WriteLine(  Convert.ToInt32(inputbinary , 2));
}

