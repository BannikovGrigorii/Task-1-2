using System;

namespace Practice
{
    public class Program1
    {
        public static void Main(string[] args) // первый вызываемый метод
        {
            Console.Write("Введите число а: "); // вывод текста без перевода строки
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите число b: ");
            int b = int.Parse(Console.ReadLine());

            int result = squareSumm(a, b);
            Console.WriteLine($"Квадрат суммы чисел = {result}"); // текст с новой строки
        }

        private static int squareSumm(int a, int b)
        {
            return ((a + b) * (a + b));
        }
    }
}
