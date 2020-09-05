using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuesGame
{
    public class Player
    {
        public Player(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }
        public string Name { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return $"Players name: {this.Name}\nPlayer type: {this.Type}";
        }

        public static void Winner(int i, int guessNumber)
        {
            Console.Clear();
            Console.WriteLine($"Winner!!!\nPlayer: {PlayerKeeper._player[i].Name}\nType: {PlayerKeeper._player[i].Type}\nGuessed number: {guessNumber}");
            Console.ReadKey();

        }

        public static string PlayerTypeSelector()
        {
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
            return type;
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

