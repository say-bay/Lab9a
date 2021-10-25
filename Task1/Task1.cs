using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Task1
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            Console.WriteLine("Вас приветствует калькулятор!");
            try
            {
                Console.Write("Введите целое число. X=");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число. Y=");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите код операции\n1 - сложение\n2 - вычетание\n3 - произведение\n4 - частное\nВаш выбор:");
                c = Convert.ToInt32(Console.ReadLine());
                if (c == 1)
                {
                    Console.WriteLine(a + b);
                }
                if (c == 2)
                {
                    Console.WriteLine(a - b);
                }
                if (c == 3)
                {
                    Console.WriteLine(a * b);
                }
                if (c == 4)
                {
                    try
                    {
                        Console.WriteLine(a / b);
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка! Деление на ноль");
                    }
                }
                else
                {
                    Console.WriteLine("Нет операции с указанным номером");
                }
            }
            catch
            {
                Console.WriteLine("Ошибка! Входная строка имела неверный формат");
            }
            Console.ReadKey();
        }
    }
}
