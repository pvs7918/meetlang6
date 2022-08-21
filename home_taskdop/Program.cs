/*
Задано натуральное число n. Необходимо перевести его в k-ичную систему счисления и
найти разность между произведением и суммой его цифр в этой системе счисления.
Например, пусть n = 239, k = 8. Тогда представление числа n в восьмеричной системе
счисления — 357, а ответ на задачу равен 3 × 5 × 7 − (3 + 5 + 7) = 90.
*/

string DecimalNumberConvertToBinary(int numb, int basis)
{
    string res = string.Empty;
    string CurSymb = string.Empty;
    int ost = numb;
    int curDig;

    while (ost > 0)
    {
        curDig = ost % basis;
        if ((curDig) > 9)
        {
            switch (curDig)
            {
                case 10:
                    CurSymb = "A";
                    break;
                case 11:
                    CurSymb = "B";
                    break;
                case 12:
                    CurSymb = "C";
                    break;
                case 13:
                    CurSymb = "D";
                    break;
                case 14:
                    CurSymb = "E";
                    break;
                case 15:
                    CurSymb = "F";
                    break;
            }
        }
        else
        {
            CurSymb = Convert.ToString(curDig);
        }
        res = CurSymb + res;
        ost /= basis;
    }
    return res;
}

Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k - основание цеелвой системы счисления: ");
int k = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{n} -> {DecimalNumberConvertToBinary(n, k)}");