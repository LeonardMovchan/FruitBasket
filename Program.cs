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
            Console.Write("Please enter the weight of the fruit basket (min weight is 40kg, the max weight is 140kg): ");
            int basketWeight = BasketWeightValidation();

            int guessNumber = 0;
            int totalAttemptscounter = 0;
            
            while (guessNumber != basketWeight)
            {
                if (totalAttemptscounter == 100) break;

                Console.WriteLine("=============MENU=============");               
                Console.WriteLine("1. Please enter the name and type of the player");
                Console.WriteLine("2. Play a game");
                Console.WriteLine("4. exit");
                StartGame startgame = (StartGame)InputNumberValidation();
                switch (startgame)
                {                  
                    case StartGame.NewPlayer:
                        {
                            Console.Write("Please enter player name: ");
                            string name = Console.ReadLine();

                            Console.Clear();
                            Console.Write("Please enter player type");
                            Console.WriteLine();
                            Console.WriteLine("1. Casual Player");
                            Console.WriteLine("2. Note Player");
                            Console.WriteLine("3. Uber Player");
                            Console.WriteLine("4. Cheater");
                            Console.WriteLine("5. Uber Cheater");
                            string type = "";

                            PlayerType playerType = (PlayerType)InputNumberValidation();

                            switch (playerType)
                            {
                                case PlayerType.CasualPlayer:
                                    {
                                        type = "Casual Player";
                                    }break;
                                case PlayerType.NotePlayer:
                                    {
                                        type = "Note Player";
                                    }break;
                                case PlayerType.UberPlayer:
                                    {
                                        type = "Uber Player";
                                    }break;
                                case PlayerType.Cheater:
                                    {
                                        type = "Cheater";
                                    }break;
                                case PlayerType.UberCheater:
                                    {
                                        type = "Uber Cheater";
                                    }break;
                                default: Console.WriteLine("There is no such player type");
                                    break;
                            }

                            Player player = new Player(name: name, type: type);
                            PlayerKeeper.Add(player);

                        }
                        break;
                    case StartGame.PlayGame:
                        {
                            while (guessNumber != basketWeight)
                            {
                                for (int i = 0; i < PlayerKeeper._player.ToArray().Length ; i++)
                                {
                                  
                                    if(PlayerKeeper._player[i].Type == "Casual Player")
                                    {
                                        guessNumber = CasualPlayer.GuessNumber();

                                        Console.WriteLine($"Player: {PlayerKeeper._player[i].Name}\nType: {PlayerKeeper._player[i].Type}\nGuessd number: {guessNumber}");
                                        totalAttemptscounter++;

                                        
                                    }
                               }
                                Console.WriteLine();
                                Console.WriteLine($"{totalAttemptscounter}");
                                Console.ReadKey();
                            }
                            break;


                        }
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
            NewPlayer = 1,
            PlayGame = 2,
        }
        enum PlayerType
        {
            NoItem = 0,
            CasualPlayer = 1,
            NotePlayer = 2,
            UberPlayer = 3,
            Cheater = 4,
            UberCheater =5

        }
    }
    



}
