using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Простой калькулятор для деления двух чисел");

        while (true) // Бесконечный цикл
        {
            // Запрос первого числа
            Console.Write("Введите A: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            // Запрос второго числа
            Console.Write("Введите B: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            // Выполнение деления
            double result = DivideNumbers(number1, number2);

            // Вывод результата
            Console.WriteLine($"Результат: {number1} / {number2} = {result}");

            // Запрос на повторный расчет
            Console.WriteLine("Хотите выполнить ещё одно вычисление? (y/n): ");
            char answer = Console.ReadKey().KeyChar; // Читаем ответ пользователя
            Console.WriteLine(); // Для новой строки

            if (char.ToLower(answer) != 'y') // Если ответ не 'y', выходим из цикла
            {
                break; // Выход из цикла
            }
        }

        Console.WriteLine("Спасибо за использование калькулятора!");
    }

    static double DivideNumbers(double num1, double num2)
    {
        if (num2 == 0) // Проверка на деление на ноль
        {
            Console.WriteLine("Ошибка: Деление на ноль невозможно.");
            return double.NaN; // Возвращаем "не число"
        }
        return num1 / num2;
    }
}