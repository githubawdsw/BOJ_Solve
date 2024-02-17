// BOJ_15973


long[] box1 = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
long[] box2 = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
(long, long, long, long) box1Point = (box1[0], box1[1], box1[2], box1[3]);
(long, long, long, long) box2Point = (box2[0], box2[1], box2[2], box2[3]);

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
    else if (box1Point.Item3 == box2Point.Item1 || box1Point.Item1 == box2Point.Item3)
        Console.WriteLine("LINE");
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
else if(FaceCheck(box1Point, box2Point.Item1, box2Point.Item2) || FaceCheck(box1Point ,box2Point.Item1, box2Point.Item4)
     || FaceCheck(box1Point, box2Point.Item3, box2Point.Item2) || FaceCheck(box1Point ,box2Point.Item3, box2Point.Item4)
     || FaceCheck(box2Point, box1Point.Item1, box1Point.Item2) || FaceCheck(box2Point, box1Point.Item1, box1Point.Item4)
     || FaceCheck(box2Point, box1Point.Item3, box1Point.Item2) || FaceCheck(box2Point, box1Point.Item3, box1Point.Item4))
        Console.WriteLine("FACE");
else if(box1Point.Item1 <= box2Point.Item1 && box1Point.Item3 >= box2Point.Item3
        && box1Point.Item2 >= box2Point.Item2 && box1Point.Item4 <= box2Point.Item4)
    Console.WriteLine("FACE");
else if (box1Point.Item1 >= box2Point.Item1 && box1Point.Item3 <= box2Point.Item3
        && box1Point.Item2 <= box2Point.Item2 && box1Point.Item4 >= box2Point.Item4)
    Console.WriteLine("FACE");
else
    Console.WriteLine("NULL");


bool FaceCheck((long,long,long,long) compare, long x , long y)
{
    if (compare.Item1 <= x && compare.Item3 >= x && compare.Item2 <= y && compare.Item4 >= y)
        return true;
    return false;
}
