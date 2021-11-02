using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            String Text = "Игра «Угадай число»";
            int centerX = (Console.WindowWidth / 2) - (Text.Length / 2);
            Console.SetCursorPosition(centerX, 0);
            Console.WriteLine(Text);
            Random random = new Random();
            bool x = true;
            while (x)
            {
                Console.Write("Введите максимальное число диапозона: ");
                String max = Console.ReadLine();
                if (max == "")
                {
                    break;
                }
                    int maxValue = Convert.ToInt32(max) + 1;
                    int number = random.Next(maxValue);
                do
                {
                    Console.Write("Введите число: ");
                    String check = Console.ReadLine();
                    if (check == "")
                    {
                        Console.WriteLine($"Загаданное число было равно {number}");
                        break;
                        x = false;
                    }
                    else
                    {
                        int countNumber = Convert.ToInt32(check);
                        if (number > countNumber)
                        {
                            Console.WriteLine("Сгенерированное число больше");
                        }
                        else
                            if (number < countNumber)
                        {
                            Console.WriteLine("Сгенерированное число меньше");
                        }
                        else
                            if (number == countNumber)
                        {
                            Console.WriteLine("Вы угадали число!\n\n");
                            break;
                        }
                    }

                } while (true);
            }
            Console.ReadKey();
        }
    }

}
