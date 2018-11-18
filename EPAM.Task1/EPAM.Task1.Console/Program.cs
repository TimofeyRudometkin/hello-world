using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер блока заданий в формате '1', '2' и т.д.");
            byte NumberBlockOfTheTask = Convert.ToByte(Console.ReadLine());
            Boolean CompleteTheprogram = false;
            while (!CompleteTheprogram)
            {
                switch (NumberBlockOfTheTask)
                {
                    case 0:
                        CompleteTheprogram = true;
                        break;
                    case 1:
                        Task0 task0 = new Task0();
                        task0.ShowTask();
                        break;
                    default:
                        Console.WriteLine("Блока вопросов №{0} нет, введите корректный номер блока вопросов или введите '0' для выхода из программы", NumberBlockOfTheTask);
                        break;
                }
                if (!CompleteTheprogram)
                {
                    Console.WriteLine("Введите номер блока заданий в формате '1', '2' и т.д. или 0 для завершения программы");
                    NumberBlockOfTheTask = Convert.ToByte(Console.ReadLine());
                }
            }
        }
    }
}
