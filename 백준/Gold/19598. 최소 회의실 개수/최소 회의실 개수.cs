// BOJ_19598



int n = int.Parse(Console.ReadLine());
List<int> startTime = new List<int>();
List<int> endTime = new List<int>();
int lastTime = 0;
for (int i = 0; i < n; i++)
{
    int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    startTime.Add(inputInfo[0]);
    endTime.Add(inputInfo[1]);
    lastTime = Math.Max(lastTime, inputInfo[1]);
}

startTime.Sort();
endTime.Sort();

int room = 0;
int ans = 0;
int startIdx = 0; int endIdx = 0;
for (int i = 0; i <= lastTime; i++)
{
    while (startIdx < n && startTime[startIdx] == i)
    {
        room++;
        startIdx++;
    }

    while (endIdx < n && endTime[endIdx] == i)
    {
        room--;
        endIdx++;
    }
    ans = Math.Max(ans, room);
}

Console.WriteLine(ans);
