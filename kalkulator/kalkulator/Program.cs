﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Простой калькулятор");

        // Запрос первого числа
        Console.Write("Введите число A: ");
        double A = Convert.ToDouble(Console.ReadLine());

        // Запрос второго числа
        Console.Write("Введите число B: ");
        double B = Convert.ToDouble(Console.ReadLine());

        // Выполнение операций
        double sum = Add(A, B);
        double difference = Subtract(A, B);
        double product = Multiply(A, B);
        double quotient = Divide(A, B);

        // Вывод результатов
        Console.WriteLine($"A + B = {sum}");
        Console.WriteLine($"A - B = {difference}");
        Console.WriteLine($"A * B = {product}");
        Console.WriteLine($"A / B = {quotient}");
    }

    static double Add(double num1, double num2)
    {
        return num1 + num2;
    }

    static double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }

    static double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    static double Divide(double num1, double num2)
    {
        if (num2 == 0) // Проверка на деление на ноль
        {
            Console.WriteLine("Ошибка: Деление на ноль невозможно.");
            return double.NaN; // Возвращаем "не число"
        }
        return num1 / num2;
    }
}