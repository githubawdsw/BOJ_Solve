// BOJ_24313



string[] an =  Console.ReadLine().Split(' ');
int a1 = int.Parse(an[0]);
int a0 = int.Parse(an[1]);
int c = int.Parse(Console.ReadLine());
int n0 = int.Parse(Console.ReadLine());

int fn = a1 * n0 + a0;
int gn = c * n0;
bool check = false;
while (fn <= gn)
{
    n0++;
    fn = a1 * n0 + a0;
    gn = c * n0;
    check = true;
    if(fn > gn)
    {
        check = false;
        break;
    }
    if (gn > 10000 )
        break;
}
if (check)
    Console.WriteLine(1);
else
    Console.WriteLine(0);

