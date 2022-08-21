/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли 
существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/

bool CanBeTriangle(int a, int b, int c)
{
    if ((a < b + c) && (b < a + c) && ((c < a + b)))
        return true;
    else
        return false;
}

Console.Write("Введите длину стороны a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину стороны b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину стороны c: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Может ли существовать треугольник?: {CanBeTriangle(a, b, c)}");