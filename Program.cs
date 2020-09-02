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

            int basketWeight = 78;
            int guessNumber = 0;
            int totalAttemptscounter = 0;

            Player player1 = new Player();
            player1.Name = "James";
            player1.Type = "CasualPlayer";


            NotePlayer player2 = new NotePlayer();
            player2.Name = "Kerrigan";
            player2.Type = "NotePlayer";

            UberPlayer player3 = new UberPlayer();
            player3.Name = "Daniel";
            player3.Type = "UberPlayer";

            Cheater player4 = new Cheater();

            player4.Name = "Zeratul";
            player4.Type = "Cheater";

            UberCheater player5 = new UberCheater();

            player4.Name = "Bismarck";
            player4.Type = "UberCheater";


            while (guessNumber != basketWeight)
            {
                if (totalAttemptscounter == 100) break;


                guessNumber = player1.GuessNumber();
                //Console.WriteLine($"Player 1: {guessNumber} = {basketWeight}");
                totalAttemptscounter++;
                if (guessNumber == basketWeight)
                {
                    Console.WriteLine();
                    Console.WriteLine("Player 1 is the winner");
                    break;
                }

                guessNumber = player2.GuessNumber();
                    //Console.WriteLine($"Player 2: {guessNumber} = {basketWeight}");

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
                //Console.WriteLine($"Player 3: {guessNumber} = {basketWeight}");


                guessNumber = player4.GuessNumber();

                if (guessNumber == basketWeight)
                {
                    Console.WriteLine();
                    Console.WriteLine("Player 4 is the winner");
                    break;
                }
                //Console.WriteLine($"Player 4: {guessNumber} = {basketWeight}");
                Console.WriteLine("-----------------------");
                totalAttemptscounter++;

                guessNumber = player5.GuessNumber();

                if (guessNumber == basketWeight)
                {
                    Console.WriteLine();
                    Console.WriteLine("Player 5 is the winner");
                    break;
                }
                //Console.WriteLine($"Player 5: {guessNumber} = {basketWeight}");
                Console.WriteLine("-----------------------");
                totalAttemptscounter++;

            }

            Console.WriteLine();
            Console.WriteLine($"{totalAttemptscounter}");
            Console.ReadKey();

            


        }
    }
}
