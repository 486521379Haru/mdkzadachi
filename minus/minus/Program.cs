using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Простой калькулятор для вычитание двух чисел");

        // Запрос первого числа
        Console.Write("ввести А: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        // Запрос второго числа
        Console.Write("ввести B: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        // Вычисление суммы
        double result = AddNumbers(number1, number2);

        // Вывод результата
        Console.WriteLine($"Результат: {number1} - {number2} = {result}");
    }

    static double AddNumbers(double num1, double num2)
    {
        return num1 - num2;
    }
}
