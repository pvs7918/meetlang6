/*
 Задача 45: Напишите программу, которая будет создавать копию заданного массива 
 с помощью поэлементного копирования.
*/

int[] NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 11);
    }
    return array;
}

int[] CopyArray(int[] array)
{
    int [] array2=new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array2[i]=array[i];
    }
    return array2;
}

Console.Write("Укажите длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
array = NewArray(array);
Console.WriteLine("Исходный массив: [" + string.Join(", ", array) + "]");
Console.WriteLine("Скопированный массив: [" + string.Join(", ", CopyArray(array)) + "]");