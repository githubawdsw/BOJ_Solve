// BOJ_14888


int n = int.Parse(Console.ReadLine());
string[] inputAn = Console.ReadLine().Split(' ');

string[] inputOper = Console.ReadLine().Split(" ");
// 덧셈(+) : 0 , 뺄셈(-) : 1, 곱셈(×) : 2, 나눗셈(÷) : 3

int[] operCount = new int[4];
for (int i = 0; i < 4; i++)
    operCount[i] = int.Parse(inputOper[i]);

int max = int.MinValue;
int min = int.MaxValue;

backtracking( 1 , int.Parse(inputAn[0]));
Console.WriteLine(  max);
Console.WriteLine(  min);


void backtracking(int idx , int result)
{
    if(idx == n)
    {
        
        max = Math.Max(max, result);
        min = Math.Min(min, result);
        return;
    }
    
    for (int i = 0; i < 4; i++)
    {
        if (operCount[i] != 0)
        {
            operCount[i]--;
            if (i == 0)
                backtracking(idx + 1, result + int.Parse(inputAn[idx]));
            else if(i == 1)
                backtracking(idx + 1, result - int.Parse(inputAn[idx]));
            else if (i == 2)
                backtracking(idx + 1, result * int.Parse(inputAn[idx]));
            else if (i == 3)
            {
                if (result < 0)
                {
                    result = -result;
                    result /= int.Parse(inputAn[idx]);
                    result = -result;
                    backtracking(idx + 1, result);
                }
                else
                    backtracking(idx + 1, result / int.Parse(inputAn[idx]));
            }
            operCount[i]++;
        }
    }
    
}