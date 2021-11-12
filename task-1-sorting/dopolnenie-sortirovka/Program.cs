using System;

namespace dopolnenie_sortirovka
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Comand = Console.ReadLine();
                if (Comand == "menu")
                {
                    Console.WriteLine("СПИСОК ДЕЙСТВИЙ");
                    Console.WriteLine("[1] Действие1");
                    Console.WriteLine("[2] Действие2");
                    Console.WriteLine("[3] Действие3");
                    Comand = Console.ReadLine();
                    Switch(Comand)
                    {
                    case "1"
                    {
                            Console.WriteLine("Персонаж выполнил Действие1");
                        }
                        break;
                    case "2"
                    {
                            Console.WriteLine("Персонаж выполнил Действие2");
                        }
                        break;
                    case "3"
                    {
                            Console.WriteLine("Персонаж выполнил Действие3");
                        }
                        break;
                    else
                        {
                            Console.WriteLine("Вы ввели не команду");
                        }
                    }
                }
                else if (Comand == "exit")
                    Console.WriteLine("Выйти из игры? yes/no");
                Comand = Console.ReadLine();
                {
                    if (Comand == "yes") break;
                }
            else
                {
                    Console.WriteLine("Вы ввели не команду");
                }
            }
        }
    }
    
}
