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
            bool play = true;
                do
                {
                    Console.Write("Введите максимальное число диапазона: ");
                    String max = Console.ReadLine();
                    if (max == "")
                    {
                        break;
                    }
                    int maxValue;
                    while (Int32.TryParse(max, out maxValue) is false)
                    {
                        Console.WriteLine("Ошибка ввода, введите корректные данные.");
                    break;
                    }
                    int number = random.Next(maxValue+1);
                    do
                    {
                        Console.Write("Введите число: ");
                        String check = Console.ReadLine();
                        if (check == "")
                        {
                            Console.WriteLine($"Загаданное число было равно {number}");
                            play = false;
                            break;
                        }
                        else
                        {
                            int countNumber;
                            while (Int32.TryParse(check, out countNumber) is false)
                            {
                                Console.WriteLine("Ошибка ввода, введите корректные данные.");
                                break;
                            }
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
                } while (play);
            Console.ReadKey();
        }
    }

}
