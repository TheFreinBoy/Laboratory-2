using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DraftForLab2
{
    class Program
    {
        static void DoBlock_1()
        {
            int n;
            double s = 0;
            Console.WriteLine("Введіть кількість чисел");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть числа");           
            for (int i = 0; i < n; i++)
            {
                s += double.Parse(Console.ReadLine());
            };
            Console.WriteLine(s / n);
        }

        static void DoBlock_2()
        {
            int num;
            int min = int.MaxValue;
            int max = int.MinValue;

            Console.WriteLine("Введіть послідовність цілих чисел, завершіть введення 0:");

            while (int.TryParse(Console.ReadLine(), out num) && num>0)
            {
                
                if (num < min)
                    min = num;

                if (num > max)
                    max = num;
            }

            if (min != int.MaxValue && max != int.MinValue)
            {
                int sum = min + max;
                Console.WriteLine($"Сума мінімального і максимального елементів: {sum}");
            }
        }

        static void DoBlock_3()
        {
            int count = 0, n;
            Console.WriteLine("Введіть десяткове натуральне число");
            n = int.Parse(Console.ReadLine());           
            if (n <= 0)
            {
                return;
            }
            do
            {
                count++;
                n /= 10;
            } while (n!= 0);
            Console.WriteLine($"Кількість цифр: {count}");
        }

        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Для виконання блоку 1 (варіант ...) введіть 1");
                Console.WriteLine("Для виконання блоку 2 (варіант ...) введіть 2");
                Console.WriteLine("Для виконання блоку 3 (варіант ...) введіть 3");
                Console.WriteLine("Для виходу з програми введіть 0");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Виконую блок 1");
                        DoBlock_1();
                        break;
                    case 2:
                        Console.WriteLine("Виконую блок 2");
                        DoBlock_2();
                        break;
                    case 3:
                        Console.WriteLine("Виконую блок 3");
                        DoBlock_3();
                        break;
                    case 0:
                        Console.WriteLine("Зараз завершимо, тільки натисніть будь ласка ще раз Enter");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Команда ``{0}'' не розпізнана. Зробіть, будь ласка, вибір із 1, 2, 3, 0.", choice);
                        break;
                }
            } while (choice != 0);
        }
    }
}

