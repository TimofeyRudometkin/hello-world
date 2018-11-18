using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task
{
    class Task0
    {
        public void ShowTask()
        {
            Console.WriteLine("Введите номер задания из первого блока заданий:");
            Console.WriteLine("'1' - Sequence;");
            Console.WriteLine("'2' - Simple;");
            Console.WriteLine("'3' - Square;");
            Console.WriteLine("или '0' для выхода.");
            byte NumberOfTheTask = Convert.ToByte(Console.ReadLine());

            Boolean FinishTheJob = false;
            string Result = "";

            while (FinishTheJob == false)
            {
                switch (NumberOfTheTask)
                {
                    case 0:
                        FinishTheJob = true;
                        break;
                    case 1:
                        Console.WriteLine("Введите положительное число.");
                        Result = Task0_1(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine(Result);
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("Введите положительное целое число.");
                        Result = Task0_2(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine(Result);
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("Введите положительное нечётное число равное длине стороны квадрата.");
                        Task0_3(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine();
                        break;
                    default:
                        Console.Write("Введено не корректное значение. ");
                        break;
                }
                if (!FinishTheJob)
                {
                    Console.WriteLine("Введите номер задания (1, 2 или 3) или 0 для выхода из данного блока заданий.");
                    NumberOfTheTask = Convert.ToByte(Console.ReadLine());
                }
            }
        }
        private static string Task0_1(int N)
        {
            string TheGeneratedString = "";
            //Ноль не является положительным числом, но добавим проверку
            if (N < 1)
                return TheGeneratedString = "Введённое число не является положительным числом, возможно вы ввели '0'.";

            //Добавляем в строку первое число
            TheGeneratedString = "1";

            //Если в строке содержится болше одного числа
            if (N > 1)
            {
                //Формируем строку до значения N-1
                for (int i = 2; i < N; i++)
                {
                    TheGeneratedString = TheGeneratedString + ", " + i;
                }
                //Добавляем в строку число N и возвращаем полученную строку
                TheGeneratedString = TheGeneratedString + ", " + N;
            }
            return TheGeneratedString;
        }

        private static string Task0_2(int N)
        {
            int TheNumberOfTheDivisionsWithoutRemainder = 0;

            for (int i = 1; i <= N; i++)
            {
                if ((N % i) == 0)
                    TheNumberOfTheDivisionsWithoutRemainder = TheNumberOfTheDivisionsWithoutRemainder + 1;
            }
            if (TheNumberOfTheDivisionsWithoutRemainder > 2)
                return "Введённое число не является простым.";
            return "Введённое число является простым.";
        }

        private static void Task0_3(int N)
        {
            if (N % 2 == 0)
                Console.WriteLine("Введено чётное число, поэтому центр будет смещён вверх и влево.");
            for(int TheWidthOfTheSquare=1;TheWidthOfTheSquare<=N;TheWidthOfTheSquare++)
            {
                for(int TheHeightOfTheSquare=1;TheHeightOfTheSquare<=N;TheHeightOfTheSquare++)
                {
                    if((TheHeightOfTheSquare==((N+1)/2))&(TheWidthOfTheSquare==((N+1)/2)))
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                    Console.WriteLine();
            }
        }
    }
}
