// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

int GetValue(string msg)
{
    System.Console.Write(msg);
    string v = Console.ReadLine();
    return Convert.ToInt32(v);
}

void GetPointValue(int[] point, int num)
{
    for (int i=0; i<3; i++)
        point[i] = GetValue("Введите " + i + " координату точки " + num + " : ");
}

double AB(int[] point1, int[] point2)
{
    int sum = 0;

    for (int i=0; i<3; i++)
        sum += (int)Math.Pow(point1[i] - point2[i], 2);

    double result = Math.Sqrt(sum);

    return result;
}

int[] A = new int[3];
int[] B = new int[3];

GetPointValue(A, 1);
GetPointValue(B, 2);

Console.WriteLine("Расстояние АВ = " + string.Format("{0:0.000}", AB(A, B)));