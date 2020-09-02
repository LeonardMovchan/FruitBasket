using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuesGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int guessNumber = 0;
            int totalAttemptscounter = 0;
            int basketWeight;
            while (true)
            {
                StartGame startgame = (StartGame)InputNumberValidation();
                switch (startgame)
                {
                    case StartGame.BasketWeight:
                        { 


                         Console.Write("Please enter the weight of the fruit basket (min weight is 40kg, the max weight is 140kg): ");
                         basketWeight = BasketWeightValidation();
                        }break;
                    case StartGame.NewPlayer:
                        {
                            Console.Write("Please enter player name: ");
                            string name = Console.ReadLine();
                            Console.Write("Please enter player type: ");
                            string type = Console.ReadLine();

                            Player player = new Player(name: name, type: type);
                            PlayerKeeper.Add(player);

                        }
                        break;

                        while (guessNumber != basketWeight)
                        {
                            if (totalAttemptscounter == 100) break;


                            guessNumber = player1.GuessNumber();
                            Console.WriteLine($"Player 1: {guessNumber} = {basketWeight}");
                            totalAttemptscounter++;
                            if (guessNumber == basketWeight)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Player 1 is the winner");
                                break;
                            }

                            guessNumber = player2.GuessNumber();
                            Console.WriteLine($"Player 2: {guessNumber} = {basketWeight}");

                            if (guessNumber == basketWeight)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Player 2 is the winner");
                                break;
                            }
                            totalAttemptscounter++;

                            guessNumber = player3.GuessNumber();
                            if (guessNumber == basketWeight)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Player 3 is the winner");
                                break;
                            }

                            totalAttemptscounter++;
                            Console.WriteLine($"Player 3: {guessNumber} = {basketWeight}");


                            guessNumber = player4.GuessNumber();

                            if (guessNumber == basketWeight)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Player 4 is the winner");
                                break;
                            }
                            Console.WriteLine($"Player 4: {guessNumber} = {basketWeight}");
                            Console.WriteLine("-----------------------");
                            totalAttemptscounter++;

                            guessNumber = player5.GuessNumber();

                            if (guessNumber == basketWeight)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Player 5 is the winner");
                                break;
                            }
                            Console.WriteLine($"Player 5: {guessNumber} = {basketWeight}");
                            Console.WriteLine("-----------------------");
                            totalAttemptscounter++;

                        }

                        Console.WriteLine();
                        Console.WriteLine($"{totalAttemptscounter}");
                        Console.ReadKey();
                }
            }
        }

        public static int BasketWeightValidation()
        {
            int weight;
            while (!int.TryParse(Console.ReadLine(), out weight) || weight < 40 || weight > 140)
            {
                Console.WriteLine("Please enter the wight of the basket (from 40 to 140)");
            }
            return weight;

        }
        public static int InputNumberValidation()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
            {
                Console.WriteLine("Please enter the number");
            }
            return number;
        }


        enum StartGame
        {
            NoItem = 0,
            BasketWeight = 1,
            NewPlayer = 2
        }
    }
    



}
