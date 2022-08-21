/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/

string DecimalNumberConvertToBinary(int numb)
{
    string res = string.Empty;
    int ost = numb;
    while (ost > 0)
    {
        res = ost % 2 + res;
        ost /= 2;
    }
    return res;
}

Console.Write("Введите десятичное число: ");
int numb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{numb} -> {DecimalNumberConvertToBinary(numb)}");