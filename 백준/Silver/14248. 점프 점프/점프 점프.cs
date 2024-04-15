int n = int.Parse(Console.ReadLine());
string[] stones = Console.ReadLine().Split(' '); 
int s = int.Parse(Console.ReadLine()) - 1;

bool[] visited = new bool[n];
Queue<int> queue = new Queue<int>();
int count = 0; 

queue.Enqueue(s);
visited[s] = true;
count++;

while (queue.Count > 0)
{
    int current = queue.Dequeue();
    int jumpDistance = 0;

    if (!int.TryParse(stones[current], out jumpDistance))
    {
        continue;
    }

    jumpDistance = int.Parse(stones[current]);
    int left = current - jumpDistance;
    if (left >= 0 && !visited[left])
    {
        queue.Enqueue(left);
        visited[left] = true;
        count++;
    }

    int right = current + jumpDistance;
    if (right < n && !visited[right])
    {
        queue.Enqueue(right);
        visited[right] = true;
        count++;
    }
}

Console.WriteLine(count);