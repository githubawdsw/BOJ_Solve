// BOJ_11664


int[] inputPos = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int[] A = { inputPos[0], inputPos[1], inputPos[2] };
int[] B = { inputPos[3], inputPos[4], inputPos[5] };
int[] C = { inputPos[6], inputPos[7], inputPos[8] };

double[] vAB = new double[3];
double[] vAC = new double[3];
for (int i = 0; i < 3; i++)
{
    vAB[i] = B[i] - A[i];
    vAC[i] = C[i] - A[i];
}

double temp = (vAB[0] * vAC[0] + vAB[1] * vAC[1] + vAB[2] * vAC[2])
            / (vAB[0] * vAB[0] + vAB[1] * vAB[1] + vAB[2] * vAB[2]);

if(temp > 1 || temp < 0)
{
    double ac = (C[0] - A[0]) * (C[0] - A[0]) + (C[1] - A[1]) * (C[1] - A[1]) + (C[2] - A[2]) * (C[2] - A[2]);
    double bc = (C[0] - B[0]) * (C[0] - B[0]) + (C[1] - B[1]) * (C[1] - B[1]) + (C[2] - B[2]) * (C[2] - B[2]);
    double ans = ac < bc ? ac : bc;

    Console.WriteLine(Math.Sqrt(ans));
}
else
{
    double[] P = { A[0] + temp * vAB[0], A[1] + temp * vAB[1], A[2] + temp * vAB[2] };
    double ans = (C[0] - P[0]) * (C[0] - P[0]) + (C[1] - P[1]) * (C[1] - P[1]) + (C[2] - P[2]) * (C[2] - P[2]);

    Console.WriteLine(Math.Sqrt(ans));
}