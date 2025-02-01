using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Calculate1
    {
        /// <summary>
        /// Поля класса
        /// </summary>
        public double Number1;
        public double Number2;

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Calculate1() { } 
        /// <summary>
        /// Конструктор с 1 параметром
        /// </summary>
        /// <param name="Number1"></param>
        public Calculate1(double Number1)
        {
            this.Number1 = Number1;
        }
        /// <summary>
        /// Конструктор с 2 параметрами
        /// </summary>
        /// <param name="Number1"></param>
        /// <param name="Number2"></param>
        public Calculate1(double Number1, double Number2) : this(Number1)
        {
            this.Number2 = Number2;
        }

        /// <summary>
        /// Вывод чисел с помощью метода Info
        /// </summary>
        /// <returns></returns>
        public string Info()
        {
            return $"Первое число: {Number1}; " +
                $"Второе число: {Number2}";
        }
        public double SquareRoot()
        {
            double product = Number1 * Number2;
            return product >= 0 ? Math.Sqrt(product) : Double.NaN;
        }
        /// <summary>
        /// Вывод чисел с использованием метода ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Первое число: {Number1}," +
                $"Второе число: {Number2}";
        }
    }
}
