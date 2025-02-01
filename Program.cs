using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Создание объекта без параметров и присваивание значений полям
            Calculate1 calc1 = new Calculate1();
            calc1.Number1 = 3.6;
            calc1.Number2 = 8.5;
            Console.WriteLine(calc1.Info());
            Console.WriteLine($"Вывод: {calc1.SquareRoot()}");

            
            //Создание обьекта с явной инициализацией
            Calculate1 calc2 = new Calculate1(3.6, 4.7);
            Console.WriteLine(calc2.Info());
            Console.WriteLine($"Вывод: {calc2.SquareRoot()}");

            //Ввод значений через клавиатуру
            Console.Write("Введите первое число: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            //Вывод значений
            Calculate1 calc3 = new Calculate1(number1, number2);
            Console.WriteLine(calc3.Info());
            Console.WriteLine($"Вывод: {calc3.SquareRoot()}");

            Console.Read();

        }
    }
}
