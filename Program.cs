//**************************************************************************************************************
//* Практическая работа № 6                                                                                    *
//* Выполнил: Пирогов Д., группа 2ИСП                                                                          *
//* Задание: составить программу работы алгоритма усложненного ветвления с обработкой ошибок времени выполнения*
//**************************************************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pr6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа № 5\nЗдравствуйте!");
            Console.Write("Введите номер вашего шестизначного билета: "); // ввод исходных данных

            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                switch (a >= 100000 && a <= 999999) // если пользователь вводит нужное количество цифр, то
                {
                    case true:
                        // вычисляем сумму цифр первой половины билета
                        int sum = a / 100000 + (a / 10000) % 10 + (a / 1000) % 10;
                        // вычисляем сумму цифр второй половины билета
                        int sum1 = (a / 100) % 10 + (a / 10) % 10 + a % 10;
                        Console.WriteLine(sum == sum1 ? "Билет является счастливым!" : "Билет не является счастливым."); // если сумма цифр первой половины билета равна сумме цифр второй половины, то билет считается счастливым
                        break;
                    case false:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nВведите шестизначное число!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                }
            }
            catch (FormatException e) // частное исключение
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nОшибка ввода \n" + e.Message); // вывод ошибки на экран
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            catch (Exception e) // общее исключение
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nОшибка ввода \n" + e.Message); // вывод ошибки на экран
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine("\nДо свидания!");
            Console.ReadKey();
        }
    }
}
