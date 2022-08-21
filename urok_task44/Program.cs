/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

int[] FibonachiNumbers(int N, int n1, int n2)
{
    int[] f = new int[N];
    //базис
    f[0] = n1;
    f[1] = n2;
    for (int i = 2; i < N; i++)
    {
        f[i] = f[i - 1] + f[i - 2];
    }
    return f;
}

Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("[" + string.Join(", ", FibonachiNumbers(N, 0, 1)) + "]");