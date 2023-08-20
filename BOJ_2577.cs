// BOJ_2577


int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int mul = a * b * c;
string tostring = mul.ToString();
int[] arr = new int[10];
for (int i = 0; i <tostring.Length; i++)
    arr[tostring[i] - '0']++;

for (int i = 0; i < 10; i++)
    Console.WriteLine(arr[i]);
