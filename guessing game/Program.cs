using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number;           
            int nextGame = 1;
            while (nextGame > 0)
            {              
                int guess = random.Next(1, 10);
                nextGame = 0;
                Console.WriteLine("Загадай цифру от 1 до 10.");
                number = int.Parse(Console.ReadLine());
                if (number == guess) Console.WriteLine("Ты угадал!");
                else Console.WriteLine("Ты не угадал(а). Было число:" + guess);

                Console.WriteLine("Начать новую игру? 1 - Да, 0 - Нет");   
                nextGame = int.Parse(Console.ReadLine());
            }            
        }
    }
}
