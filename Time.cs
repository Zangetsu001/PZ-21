using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Time
    {
        /// <summary>
        /// Создание полей
        /// </summary>
        public int hours;
        public int minutes;
        public int seconds;

        /// <summary>
        /// Создание пустого параметров
        /// </summary>
        public Time() { }
        /// <summary>
        /// Конструктор с 1 параметром
        /// </summary>
        /// <param name="hours"></param>
        public Time(int hours)
        {
            this.hours = hours;
        }
        /// <summary>
        /// Конструктор с 2 параметрами
        /// </summary>
        /// <param name="hours"></param>
        /// <param name="minutes"></param>
        public Time(int hours, int minutes) : this(hours)
        {
            this.minutes = minutes;
        }
        /// <summary>
        /// Конструктор с 3 параметрами
        /// </summary>
        /// <param name="hours"></param>
        /// <param name="minutes"></param>
        /// <param name="seconds"></param>
        public Time(int hours, int minutes, int seconds) : this(hours, minutes)
        {
            this.seconds = seconds;
        }
        /// <summary>
        /// Функция формирования строки с информацией об объекте
        /// </summary>
        /// <returns>Info</returns>
        public string Info()
        {
            return $"Время: {hours:d2}:{minutes:d2}:{seconds:d2}";
        }
        /// <summary>
        /// Функция обработки значений полей: вычислить общее количество минут
        /// </summary>
        /// <returns>Total_Minutes</returns>
        public int TotalMinutes()
        {
            return hours * 60 + minutes;
        }
        /// <summary>
        /// Функция обработки значений полей: вычислить общее количество секунд
        /// </summary>
        /// <returns>Total_seconds</returns>
        public int TotalSeconds()
        {
            return (hours * 3600) + (minutes * 60) + seconds;
        }
        /// <summary>
        /// Вывод методом ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Time [Hours = {hours}, Minutes = {minutes}, Seconds = {seconds}]";
        }
    }
}
