using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            String Text = "Наименьший элемент в последовательности";
            int centerX = (Console.WindowWidth / 2) - (Text.Length / 2);
            Console.SetCursorPosition(centerX, 0);
            Console.WriteLine(Text);
            Console.WriteLine("Введите длину последовательности");
            int line = int.Parse(Console.ReadLine());
            int[] array = new int[line];
            int min = 0;
            for (int i = 0; i<line; i++)
            {
                Console.Write($"{i+1} значение: ");
                array[i] = int.Parse(Console.ReadLine());
                if (array[i]<array[min])
                {
                    min = i;
                }
            }
            Console.WriteLine($"Минимальное число в последовательности: {array[min]}");
            Console.ReadKey();
        }
    }
}
