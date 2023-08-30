

StreamReader sr = new StreamReader(Console.OpenStandardInput());

string n = sr.ReadLine();
int[] arr = new int[9];
for (int i = 0; i < n.Length; i++)
{
    if (n[i] == '6' || n[i] == '9')
        arr[6]++;
    else
        arr[int.Parse(n[i].ToString())]++;
}
if (arr[6] % 2 == 1)
    arr[6] = (arr[6] + 1) / 2;
else
    arr[6] = arr[6]  / 2;
Console.WriteLine(arr.Max());