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
            int basketWeight = Validation.BasketWeightValidation();
            int guessNumber = 0;
            int totalAttemptscounter = 0;

            do  
            {
                int totalPlayers = PlayerKeeper._player.ToArray().Length;
                
                Console.Clear();
                Console.WriteLine("=============MENU=============");
                Console.WriteLine("1. Add new player");
                Console.WriteLine("2. Play a game");
                Console.WriteLine("3. Remove Player at index");
                Console.WriteLine("4. Reset game");
                Console.WriteLine("5. Exit");
                StartGame startgame = (StartGame)Validation.InputNumberValidation();
                switch (startgame)
                {
                    case StartGame.NewPlayer:
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter the name and type of the player");

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

                            PlayerType playerType = (PlayerType)Validation.InputNumberValidation();

                            switch (playerType)
                            {
                                case PlayerType.CasualPlayer:
                                    {
                                        type = "Casual Player";
                                    }
                                    break;
                                case PlayerType.NotePlayer:
                                    {
                                        type = "Note Player";
                                    }
                                    break;
                                case PlayerType.UberPlayer:
                                    {
                                        type = "Uber Player";
                                    }
                                    break;
                                case PlayerType.Cheater:
                                    {
                                        type = "Cheater";
                                    }
                                    break;
                                case PlayerType.UberCheater:
                                    {
                                        type = "Uber Cheater";
                                    }
                                    break;
                                default:
                                    Console.WriteLine("There is no such player type");
                                    break;
                            }

                            Player player = new Player(name: name, type: type);
                            PlayerKeeper.Add(player);
                            
                        }
                        break;
                    case StartGame.PlayGame:
                        {
                            if (totalPlayers >= 2 && totalPlayers <= 8)
                            {
                                while (guessNumber != basketWeight)
                                {
                                    if (totalAttemptscounter != 100)
                                    {

                                        for (int i = 0; i < PlayerKeeper._player.ToArray().Length; i++)
                                        {

                                            if (PlayerKeeper._player[i].Type == "Casual Player")
                                            {
                                                guessNumber = CasualPlayer.GuessNumber();

                                                Console.WriteLine($"Player: {PlayerKeeper._player[i].Name}\nType: {PlayerKeeper._player[i].Type}\nGuessed number: {guessNumber}");
                                                totalAttemptscounter++;
                                                if (guessNumber == basketWeight)
                                                {
                                                    Player.Winner(i, guessNumber);                                                   
                                                    break;
                                                }

                                            }

                                            if (PlayerKeeper._player[i].Type == "Note Player")
                                            {
                                                guessNumber = NotePlayer.GuessNumber();
                                                Console.WriteLine($"Player: {PlayerKeeper._player[i].Name}\nType: {PlayerKeeper._player[i].Type}\nGuessed number: {guessNumber}");
                                                totalAttemptscounter++;
                                                if (guessNumber == basketWeight)
                                                {
                                                    Player.Winner(i,guessNumber);                                                    
                                                    break;
                                                }

                                            }

                                            if (PlayerKeeper._player[i].Type == "Uber Player")
                                            {
                                                guessNumber = UberPlayer.GuessNumber();


                                                Console.WriteLine($"Player: {PlayerKeeper._player[i].Name}\nType: {PlayerKeeper._player[i].Type}\nGuessed number: {guessNumber}");
                                                totalAttemptscounter++;
                                                if (guessNumber == basketWeight)
                                                {
                                                    Player.Winner(i, guessNumber);                                                  
                                                    break;
                                                }

                                            }

                                            if (PlayerKeeper._player[i].Type == "Cheater")
                                            {
                                                guessNumber = Cheater.GuessNumber();
                                                Console.WriteLine($"Player: {PlayerKeeper._player[i].Name}\nType: {PlayerKeeper._player[i].Type}\nGuessed number: {guessNumber}");
                                                totalAttemptscounter++;

                                                if (guessNumber == basketWeight)
                                                {
                                                    Player.Winner(i, guessNumber);                                                    
                                                    break;
                                                }

                                            }

                                            if (PlayerKeeper._player[i].Type == "Uber Cheater")
                                            {
                                                guessNumber = UberCheater.GuessNumber();
                                                Console.WriteLine($"Player: {PlayerKeeper._player[i].Name}\nType: {PlayerKeeper._player[i].Type}\nGuessed number: {guessNumber}");
                                                totalAttemptscounter++;

                                                if (guessNumber == basketWeight)
                                                {
                                                    Player.Winner(i, guessNumber);                                                   
                                                    break;
                                                }

                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Maximum number of attempts reached! ");
                                        int closestNumber = ClosestNumber(basketWeight);

                                        Console.WriteLine($"The winner is number: {closestNumber}");
                                        Console.ReadKey();
                                        

                                        break;
                                    }
                                    Console.WriteLine();
                                    Console.WriteLine($"{totalAttemptscounter}");
                                    Console.ReadKey();
                                }

                            }
                            else
                            {
                                Console.WriteLine("The minimum number of player is 2 and maximum is 8");
                            }
                        }
                        break;
                    case StartGame.RemovePlayer:
                        {
                            Console.Clear();
                            Console.Write("Please enter the index of the player you would like to remove: ");
                            Validation.IndexInputValidation();
                            
                        }break;
                    case StartGame.ResetGame:
                        {
                            totalAttemptscounter = 0;
                            guessNumber = 0;
                            CasualPlayer.ClearTotalNumberSheet();
                            UberPlayer.Number = 39;
                            UberCheater.Number = 40;
                        }
                        break;
                    case StartGame.Exit:
                        {
                            return;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("There is no such command");
                            Console.ReadKey();                           
                        }break;
                    }

                
            } while (true);

            
        }
        public static int ClosestNumber(int basketWeight)
        {
          return CasualPlayer.totalNumberSheet.ToArray().Aggregate((current, next) => Math.Abs((long)current - basketWeight) < Math.Abs((long)next - basketWeight) ? current : next);
        }
        enum StartGame
        {
            NoItem = 0,
            NewPlayer = 1,
            PlayGame = 2,
            RemovePlayer =3,
            ResetGame = 4,
            Exit = 5
        }
        enum PlayerType
        {
            NoItem = 0,
            CasualPlayer = 1,
            NotePlayer = 2,
            UberPlayer = 3,
            Cheater = 4,
            UberCheater = 5

        }
    }




}
