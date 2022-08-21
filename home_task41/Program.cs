/*
Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
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

int CalcPositiveNumbersInArray(int[] array)
{
    int cnt = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            cnt++;
    }
    return cnt;
}

Console.Write("Укажите M количество чисел для ввода: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = InputArray(M);
Console.WriteLine("Были введены числа: [" + string.Join(", ", array) + "]");
Console.WriteLine($"Введено чисел больше 0: {CalcPositiveNumbersInArray(array)}");