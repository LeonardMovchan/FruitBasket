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

            
            Console.Write("Please enter enter the weight of the basket between 40 and 140: ");
            int basketWeight = int.Parse(Console.ReadLine());

            int number = 0;
            int totalAttemptscounter = 0;

            Player player1 = new Player();
            player1.Name = "James";
            player1.Type = "CasualPlayer";


            NotePlayer player2 = new NotePlayer();
            player2.Name = "Carigan";
            player2.Type = "NotePlayer";

            UberPlayer player3 = new UberPlayer();
            player3.Name = "Daniel";
            player3.Type = "UberPlayer";

            Cheater player4 = new Cheater();

            player4.Name = "Wiltor";
            player4.Type = "Cheater";

            UberCheater player5 = new UberCheater();

            player4.Name = "Bismarck";
            player4.Type = "UberCheater";



            while (number != basketWeight)
            {
                if (totalAttemptscounter == 100) break;


                number = player1.GuessNumber();
                Console.WriteLine($"Player 1: {number} = {basketWeight}");
                totalAttemptscounter++;
                if (number == basketWeight)
                {
                    Console.WriteLine();
                    Console.WriteLine("Player 1 is the winner");
                    break;
                }

                number = player2.GuessNumber();
                    Console.WriteLine($"Player 2: {number} = {basketWeight}");

                    if (number == basketWeight)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Player 2 is the winner");
                        break;
                    }
                totalAttemptscounter++;

                number = player3.GuessNumber();
                if (number == basketWeight)
                {
                    Console.WriteLine();
                    Console.WriteLine("Player 3 is the winner");
                    break;
                }

                totalAttemptscounter++;
                Console.WriteLine($"Player 3: {number} = {basketWeight}");


                number = player4.GuessNumber();

                if (number == basketWeight)
                {
                    Console.WriteLine();
                    Console.WriteLine("Player 4 is the winner");
                    break;
                }
                Console.WriteLine($"Player 4: {number} = {basketWeight}");
                Console.WriteLine("-----------------------");
                totalAttemptscounter++;

                number = player5.GuessNumber();

                if (number == basketWeight)
                {
                    Console.WriteLine();
                    Console.WriteLine("Player 5 is the winner");
                    break;
                }
                Console.WriteLine($"Player 5: {number} = {basketWeight}");
                Console.WriteLine("-----------------------");
                totalAttemptscounter++;

            }

            Console.WriteLine();
            Console.WriteLine($"{totalAttemptscounter}");
            Console.ReadKey();

            


        }
    }
}
