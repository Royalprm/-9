using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упражнение_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int[] mathSymb = { 1, 2, 3, 4 };

            try
            {
                Console.Write("Введите целое число: X = ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число: Y = ");
                y = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                
            }

            Console.WriteLine(@"Введите код операции:
    1 - сложение
    2 - вычитание
    3 - произведение
    4 - частное");
            Console.Write("Выш выбор: ");


            int numberSymbol = 0;

            try
            {
                numberSymbol = Convert.ToInt32(Console.ReadLine());
                
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                
            }

            double res = 0;
            try
            {
                if (numberSymbol == 1)
                {
                    res = x + y;
                }
                else if (numberSymbol == 2)
                {
                    res = x - y;
                }
                else if (numberSymbol == 3)
                {
                    res = x * y;
                }
                else if (numberSymbol == 4)
                {
                    res = x / y;
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                                
            }

            Console.WriteLine("Результат = {0}", res);

            Console.WriteLine();
            Console.Write("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();

        }
    }
}
