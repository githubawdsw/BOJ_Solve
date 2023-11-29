// BOJ_1064



int[] inputabc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int ax = inputabc[0];
int ay = inputabc[1];
int bx = inputabc[2];
int by = inputabc[3];
int cx = inputabc[4];
int cy = inputabc[5];

double max = 0f;
double min = int.MaxValue;

if ((cx - bx) * (by - ay) == (cy - by) * (bx - ax))
{
    Console.WriteLine(-1);
    return;
}

double abLine = Math.Sqrt((ax - bx) * (ax - bx) + (ay - by) * (ay - by));
double bcLine = Math.Sqrt((bx - cx) * (bx - cx) + (by - cy) * (by - cy));
double caLine = Math.Sqrt((cx - ax) * (cx - ax) + (cy - ay) * (cy - ay));

max = Math.Max(max, 2 * (abLine + bcLine));
max = Math.Max(max, 2 * (bcLine + caLine));
max = Math.Max(max, 2 * (caLine + abLine));

min = Math.Min(min, 2 * (abLine + bcLine));
min = Math.Min(min, 2 * (bcLine + caLine));
min = Math.Min(min, 2 * (caLine + abLine));

Console.WriteLine( max - min);
