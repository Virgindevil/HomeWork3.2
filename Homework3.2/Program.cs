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
            Console.ForegroundColor = ConsoleColor.DarkGreen;            
            Console.WriteLine("Сколько у вас карт на руке?");
            int cards = int.Parse(Console.ReadLine());     
            for (int i = 0; i < cards; i++)
            {
                Console.WriteLine("Какая у вас карта? Подсказка: Карты от 2 до 10 и Валет - J, Дама -  Q, Король -  K, Туз - T.");
                switch (Console.ReadLine())
                {
                    case "2":
                        sum = (sum + 2);
                        break;
                    case "3":
                        sum = (sum + 3);
                        break;
                    case "4":
                        sum = (sum + 4);
                        break;
                    case "5":
                        sum = (sum + 5);
                        break;
                    case "6":
                        sum = (sum + 6);
                        break;
                    case "7":
                        sum = (sum + 7);
                        break;
                    case "8":
                        sum = (sum + 8);
                        break;
                    case "9":
                        sum = (sum + 9);
                        break;
                    case "10":
                        sum = (sum + 10);
                        break;
                    case "J":
                        sum = (sum + 10);
                        break;
                    case "j":
                        sum = (sum + 10);
                        break;
                    case "Q":
                        sum = (sum + 10);
                        break;
                    case "q":
                        sum = (sum + 10);
                        break;
                    case "K":
                        sum = (sum + 10);
                        break;
                    case "k":
                        sum = (sum + 10);
                        break;
                    case "t":
                        sum = (sum + 10);
                        break;
                    case "T":
                        sum = (sum + 10);
                        break;                    
                }
            }
            Console.WriteLine();
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
