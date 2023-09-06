// Задача 41: Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше "0" ввёл пользователь.

// 0, 7, 8, -2, -4 -> 2

Console.Write("Какое кол-во чисел мы будем вводить? -> ");
int size = Convert.ToInt32(Console.ReadLine());

int[] SaveEnterNumbers(int sizeArr)
{
    int[] EnterNumbers = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите число № {i + 1} -> ");
        EnterNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    return EnterNumbers;
}

int SumEnterPositiveNumbers(int[] arr)
{
    int index = 0;
    int sum = 0;
    while (index < size)
    {
        if (arr[index] > 0) sum += 1;
        index++;
    }
    return sum;
}

int[] arr = SaveEnterNumbers(size);
int sumEnterPositiveNumbers = SumEnterPositiveNumbers(arr);

void PrintEnterNumbers(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]},");
        else Console.Write($"{arr[i]}");
    }
    Console.Write($" -> {sumEnterPositiveNumbers}");
}

PrintEnterNumbers(arr);