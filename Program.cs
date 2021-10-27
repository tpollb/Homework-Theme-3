using System;

namespace Homework_Theme_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string Player1Name;
            string Player2Name;

            int PlayerNumber;
            
            int i;
            
            int MinGameNumber = 12;
            int MaxGameNumber = 20;
            var random = new Random();
            int GameNumber = random.Next(MinGameNumber, MaxGameNumber);
            
            int flag;

            //определение имён
            Console.WriteLine("Player 1 please enter your name");
            Player1Name = Console.ReadLine();
            Console.WriteLine("Player 2 please enter your name");
            Player2Name = Console.ReadLine();

            Console.WriteLine($"Game number is: {GameNumber}");
            
            //основной цикл
            for (i = 1; i < (MaxGameNumber - MinGameNumber); i++)
            {
                flag = i % 2;
                if (flag != 0)
                {
                    Console.WriteLine("Player 1, your step (1 to 4): ");

                } else
                {
                    Console.WriteLine("Player 2, your step (1 to 4):");
                }

                //ввод данных и обработка
                PlayerNumber = Convert.ToInt32(Console.ReadLine());
                if (PlayerNumber < 1 || PlayerNumber > 4)
                {
                    Console.WriteLine("Please enter correct value 1 to 4");
                    PlayerNumber = Convert.ToInt32(Console.ReadLine());
                } else
                {
                    GameNumber = GameNumber - PlayerNumber;
                }

                Console.WriteLine($"Game number is: {GameNumber}");

                // условие выигрыша
                if (GameNumber <= 0)
                {
                    if (flag != 0)
                    {
                        Console.WriteLine($"Player {Player1Name} Win");
                    } else
                    { 
                        Console.WriteLine($"Player {Player2Name} Win");
                    }
                    break;
                }
                
            }
            
            Console.ReadKey();
        }
    }
}
