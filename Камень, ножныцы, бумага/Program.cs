using System;

namespace Камень__ножныцы__бумага
{
    public enum YourChoise { Камень, Ножницы, Бумага }
    public enum CompChoise { Камень, Ножницы, Бумага }

    class Program
    {
        static void Main(string[] args)
        {
            int win = 0;
            int lose = 0;
            int draw = 0;

            do
            {
                Console.WriteLine("Выберете: 1.Камень 2.Ножницы 3.Бумага");
                Console.Write("Ваш выбор: ");
                YourChoise z = (YourChoise)(int.Parse(Console.ReadLine()) - 1);
                CompChoise c = (CompChoise)(new Random().Next(0, 3));

                Console.WriteLine();

                switch (z)
                {
                    case YourChoise.Камень:
                        Console.WriteLine("Вы выбрали камень.");

                        if (c == CompChoise.Камень)
                        {
                            Console.WriteLine("Комп выбрал тоже камень.");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Ничья.");
                            Console.ResetColor();
                            draw++;
                        }

                        if (c == CompChoise.Бумага)
                        {
                            Console.WriteLine("Комп выбрал бумагу.");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ты проиграл.");
                            Console.ResetColor();
                            lose++;
                        }

                        if (c == CompChoise.Ножницы)
                        {
                            Console.WriteLine("Комп выбрал ножницы.");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Ты выграл.");
                            Console.ResetColor();
                            win++;
                        }
                        break;

                    case YourChoise.Ножницы:
                        Console.WriteLine("Вы выбрали ножницы.");

                        if (c == CompChoise.Камень)
                        {
                            Console.WriteLine("Комп выбрал камень.");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ты проигал.");
                            Console.ResetColor();
                            lose++;
                        }

                        if (c == CompChoise.Бумага)
                        {
                            Console.WriteLine("Комп выбрал бумагу.");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Ты выграл.");
                            Console.ResetColor();
                            win++;
                        }

                        if (c == CompChoise.Ножницы)
                        {
                            Console.WriteLine("Комп выбрал тоже ножницы.");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Ничья.");
                            Console.ResetColor();
                            draw++;
                        }
                        break;

                    case YourChoise.Бумага:
                        Console.WriteLine("Вы выбрали бумагу.");

                        if (c == CompChoise.Камень)
                        {
                            Console.WriteLine("Комп выбрал камень.");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Ты выграл.");
                            Console.ResetColor();
                            win++;
                        }

                        if (c == CompChoise.Бумага)
                        {
                            Console.WriteLine("Комп выбрал тоже бумагу.");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Ничья.");
                            Console.ResetColor();
                            draw++;
                        }

                        if (c == CompChoise.Ножницы)
                        {
                            Console.WriteLine("Комп выбрал ножницы.");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ты проиграл.");
                            Console.ResetColor();
                            lose++;
                        }
                        break;

                    default:
                        Console.WriteLine("Выберете 1, 2 или 3.");
                        break;
                }
                Console.WriteLine("\n--Нажмите \"Enter\" чтобы продолжить или \"Escape\" чтобы вывести счет--\n");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine($"Побед: {win}");
            Console.WriteLine($"Поражений: {lose}");
            Console.WriteLine($"Ничейных партий: {draw}");

            Console.ReadLine();
        }
    }
}