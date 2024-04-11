// BOJ_20055


using System.Collections.Concurrent;

int[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnk[0];
int k = inputnk[1];
int[] inputDur = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int[] durability = new int[205];
List<int> robotPos = new List<int>();
int count = 0;
for (int i = 0; i < 2 * n; i++)
{
    durability[i] = inputDur[i];
	if (inputDur[i] == 0)
		count++;
}

int ans = 0;
while (count < k)
{
	ans++;
	ConveyorRotate();
	MoveRobot();
	PutOnRobot();
}
Console.WriteLine(ans);

void ConveyorRotate()
{
	int temp = durability[2 * n - 1];
	for (int i = 2 * n - 1; i > 0; i--)
	{
		durability[i] = durability[i - 1];
	}
	durability[0] = temp;

	for (int i = 0; i < robotPos.Count; i++)
	{
		robotPos[i]++;
		if (robotPos[i] == n - 1)
		{
			PutDownRobot(i);
			i--;
		}
	}
}

void MoveRobot()
{
	for (int i = 0; i < robotPos.Count; i++)
	{
		var cur = robotPos[i];
		if (durability[cur + 1] != 0 && !robotPos.Contains(cur + 1))
		{
			durability[cur + 1]--;
			if (durability[cur + 1] == 0)
				count++;

			robotPos[i]++;
            if (robotPos[i] == n - 1)
			{
                PutDownRobot(i);
				i--;
			}
        }
	}
}

void PutOnRobot()
{
	if (durability[0] != 0)
	{
		robotPos.Add(0);
		durability[0]--;
        if (durability[0] == 0)
            count++;
    }
}

void PutDownRobot(int i)
{
    robotPos.RemoveAt(i);
}