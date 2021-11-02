using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            String Text = "Случайная матрица";
            int centerX = (Console.WindowWidth / 2) - (Text.Length / 2);
            Console.SetCursorPosition(centerX,0);
            Console.WriteLine(Text);
            Console.Write("Введите количество строк в матрице: ");
            int line = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов в матрице: ");
            int column = int.Parse(Console.ReadLine());
            Random random = new Random();
            int[,] array = new int[line, column];
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(1, 100);
                    sum += array[i, j];
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сумма элементов в матрице равна: {sum}");
            Console.ReadKey();
        }
    }
}
