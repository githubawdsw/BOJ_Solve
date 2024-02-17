// BOJ_15973


int[] box1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] box2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
(int, int, int, int) box1Point = (box1[0], box1[1], box1[2], box1[3]);
(int, int, int, int) box2Point = (box2[0], box2[1], box2[2], box2[3]);

if(box1Point.Item1 == box2Point.Item1 || box1Point.Item3 == box2Point.Item3)
{
    if(box1Point.Item2 > box2Point.Item4)
        Console.WriteLine("NULL");
    else if (box1Point.Item4 < box2Point.Item2)
        Console.WriteLine("NULL");
    else if (box1Point.Item4 == box2Point.Item2 || box1Point.Item2 == box2Point.Item4)
        Console.WriteLine("LINE");
    else
        Console.WriteLine("FACE");
}
else if (box1Point.Item1 == box2Point.Item3 || box1Point.Item3 == box2Point.Item1)
{
    if (box1Point.Item2 > box2Point.Item4)
        Console.WriteLine("NULL");
    else if (box1Point.Item4 < box2Point.Item2)
        Console.WriteLine("NULL");
    else if (box1Point.Item4 == box2Point.Item2)
        Console.WriteLine("POINT");
    else if (box1Point.Item2 == box2Point.Item4)
        Console.WriteLine("POINT");
    else
        Console.WriteLine("LINE");
}
else if (box1Point.Item2 == box2Point.Item2 || box1Point.Item4 == box2Point.Item4)
{
    if (box1Point.Item1 > box2Point.Item3)
        Console.WriteLine("NULL");
    else if (box1Point.Item3 < box2Point.Item1)
        Console.WriteLine("NULL");
    else
        Console.WriteLine("FACE");
}
else if (box1Point.Item2 == box2Point.Item4 || box1Point.Item4 == box2Point.Item2)
{
    if (box1Point.Item1 > box2Point.Item3)
        Console.WriteLine("NULL");
    else if (box1Point.Item3 < box2Point.Item1)
        Console.WriteLine("NULL");
    else if (box1Point.Item3 == box2Point.Item1)
        Console.WriteLine("POINT");
    else if (box1Point.Item1 == box2Point.Item3)
        Console.WriteLine("POINT");
    else
        Console.WriteLine("LINE");
}
else if(FaceCheck(box2Point.Item1, box2Point.Item2) || FaceCheck(box2Point.Item1, box2Point.Item4)
     || FaceCheck(box2Point.Item3, box2Point.Item2) || FaceCheck(box2Point.Item3, box2Point.Item4))
        Console.WriteLine("FACE");
else if(box1Point.Item1 < box2Point.Item1 && box1Point.Item3 > box2Point.Item3
        && box1Point.Item2 > box2Point.Item2 && box1Point.Item4 < box2Point.Item4)
    Console.WriteLine("FACE");
else if (box1Point.Item1 > box2Point.Item1 && box1Point.Item3 < box2Point.Item3
        && box1Point.Item2 < box2Point.Item2 && box1Point.Item4 > box2Point.Item4)
    Console.WriteLine("FACE");
else
    Console.WriteLine("NULL");


bool FaceCheck(int x , int y)
{
    if (box1Point.Item1 < x && box1Point.Item3 > x && box1Point.Item2 < y && box1Point.Item4 > y)
        return true;
    return false;
}
