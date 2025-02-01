using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создание объекта без параметров и присваивание значений полям
            Time time1 = new Time();
            time1.hours = 5;
            time1.minutes = 23;
            time1.seconds = 43;
            Console.WriteLine(time1.Info());
            Console.WriteLine("Общее количество минут: " + time1.TotalMinutes());
            Console.WriteLine("Общее количество секунд: " + time1.TotalSeconds());

            //Создание объекта с явной инициализацией
            Time time2 = new Time(3, 42, 75);
            Console.WriteLine(time2.Info());
            Console.WriteLine("Общее количество минут: " + time1.TotalMinutes());
            Console.WriteLine("Общее количество секунд: " + time1.TotalSeconds());

            //Ввод значений с клавиатуры и создание объекта
            Console.Write("Введите количество часов: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество минут: ");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество секунд: ");
            int seconds = Convert.ToInt32(Console.ReadLine());

            //Вывод значения
            Time time3 = new Time(hours, minutes, seconds);
            Console.WriteLine(time3.Info());
            Console.WriteLine("Общее количество минут: " + time1.TotalMinutes());
            Console.WriteLine("Общее количество секунд: " + time1.TotalSeconds());
        }
    }
}
