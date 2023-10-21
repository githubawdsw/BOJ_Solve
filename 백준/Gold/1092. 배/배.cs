// BOJ_1092



int n = int.Parse(Console.ReadLine());
string[] inputCrane = Console.ReadLine().Split(' ');
int m = int.Parse(Console.ReadLine());
string[] inputBox = Console.ReadLine().Split(" ");

List<int> craneList = new List<int>();
for (int i = 0; i < n; i++)
    craneList.Add(int.Parse(inputCrane[i]));

List< int >boxList =  new List< int >();
for (int i = 0; i < m; i++)
    boxList.Add(int.Parse(inputBox[i]));

craneList.Sort();
boxList.Sort();
craneList.Reverse();
boxList.Reverse();

int count = 0;
if(craneList[0]  < boxList[0])
    Console.WriteLine(  -1 );
else
{
    while (boxList.Count > 0)
    {
        count++;
        for (int i = 0; i < craneList.Count; i++)
        {
            for (int j = 0; j < boxList.Count; j++)
            {
                if (craneList[i] >= boxList[j])
                {
                    boxList.RemoveAt(j);
                    break;
                }
            }
        }
    }
    Console.WriteLine( count );
}
