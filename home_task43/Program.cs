/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

int[] InputArray(int M)
{
    int[] array = new int[M];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} число из {M}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

double[] CalcXY(double k1, double b1, double k2, double b2)
{
    double[] pnt = new double[2];
    pnt[0] = (b2 - b1) / (k1 - k2);
    pnt[1] = k1 * pnt[0] + b1;
    return pnt;
}

Console.Write("Парамерты прямой 1. Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Парамерты прямой 1. Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Парамерты прямой 2. Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Парамерты прямой 2. Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double[] point = CalcXY(k1, b1, k2, b2);
Console.WriteLine($"Решение. X: {point[0]:f1}, Y: {point[1]:f1}");