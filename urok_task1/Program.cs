/*
перевернуть массив
*/
void NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 10);
}

int[] PairsMultuplicationInArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
    return array;
}


Console.Write("Количесто элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine()!);
int[] array = new int[n];
NewArray(array);
Console.WriteLine("Исходный массив: [" + string.Join(", ", array) + "]");
Console.WriteLine("Результат: [" + string.Join(", ", PairsMultuplicationInArray(array)) + "]");
