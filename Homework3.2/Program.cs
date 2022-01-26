using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;            
            Random random = new Random();
            Random rand = new Random();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Добро пожаловать в блекджек на минималках!", 30);
            Console.WriteLine("Сколько у вас карт на руке?");
            int cards = int.Parse(Console.ReadLine());     
            for (int i = 0; i < cards; i++)
            {
                Console.WriteLine("Какая у вас карта? Если с числом, нажмите 1. Если с картинкой - нажмите 2.");
                int swap = int.Parse(Console.ReadLine());
                if (swap == 1)
                {
                    Console.WriteLine("Введите номинал карты: (Подсказка: От 2 до 10)");
                    int number = int.Parse(Console.ReadLine());
                    if (number <= 1)
                    {
                        Console.WriteLine("Не жульничайте! Введите число от 2 до 10!");
                        Console.WriteLine();
                        int rightnumber = int.Parse(Console.ReadLine());
                        sum = sum + rightnumber;
                    }
                    else
                    {
                        sum = sum + number;
                    }
                }
                else
                {
                    Console.WriteLine("Введите букву карты: (Подсказка: J - Валет, Q - Дама, K - Король,  T - Туз.)");
                    char picture = char.Parse(Console.ReadLine());
                    switch (picture)
                    {
                        case 'J':
                            sum = (sum + 10);
                            break;
                        case 'j':
                            sum = (sum + 10);
                            break;
                        case 'Q':
                            sum = (sum + 10);
                            break;
                        case 'q':
                            sum = (sum + 10);
                            break;
                        case 'K':
                            sum = (sum + 10);
                            break;
                        case 'k':
                            sum = (sum + 10);
                            break;
                        case 'T':
                            sum = (sum + 10);
                            break;
                        case 't':
                            sum = (sum + 10);
                            break;
                    }                    
                }
            }
            Console.WriteLine();
            Console.WriteLine(sum);
            if (sum == 21)
            {
                Console.WriteLine("Отлично! Вы победили!");
            }
            if (sum < 21)
            {
                Console.WriteLine("Увы! Недобор!");
            }
            if (sum > 21)
            {
                Console.WriteLine("Увы! Перебор!");
            }

            Console.ReadKey();
        }
    }
}
