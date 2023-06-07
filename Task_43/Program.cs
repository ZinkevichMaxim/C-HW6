// ФОРМУЛА ДЛЯ ДЗ
// Точка пересечения (x, y) = ((b1×c2 − b2×c1)/(a1×b2 − a2×b1), (c1×a2 − c2×a1)/(a1×b2 − a2×b1)) есть в чате в самом конце семинара

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

double Prompt(string msg)
{
    Console.WriteLine(msg);
    string Value = Console.ReadLine();
    if (int.TryParse(Value, out int vol) == false)
    {
        Console.WriteLine("Это не числовой тип данных");
    }
    return vol;
}


double b1 = Prompt("Введите занчение переменной b1");
double k1 = Prompt("Введите занчение переменной k1");
double b2 = Prompt("Введите занчение переменной b2");
double k2 = Prompt("Введите занчение переменной k2");
double x = - (b1 - b2) / (k1 - k2);                            
double y = k1 * x + b1;                           
Console.WriteLine($"Точка пересечения двух прямых: {x},{y}");


