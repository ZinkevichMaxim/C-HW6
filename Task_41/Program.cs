Console.Clear();

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int len = Prompt("Введите колличество проверяемых чисел"); //ПРОВЕРКА
int[] array = FillArray(len);
PrintArray(array);
Console.WriteLine();
CountPositivNomber(array);

int Prompt(string msg)
{
    Console.WriteLine(msg);
    string value = Console.ReadLine();
    if(int.TryParse(value, out int val) == false)
    {
        Console.WriteLine("Это не число");
    }
    return val;
}



int[] FillArray(int len)
{
    int [] arr = new int[len];
    for(int i = 0; i < len; i++)
    {
        arr[i] = Prompt("Введите число");
    }
    return arr;
}


void PrintArray(int[] aarr)
{
    for(int i = 0; i < aarr.Length; i++)
    {
        Console.Write($"{aarr[i]}, ");
    }
}

void CountPositivNomber(int[] arra)
{
    int count = 0;
    for(int i = 0; i < arra.Length; i++)
    {
        if (arra[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Вы ввели {count} положительных числа");
}
